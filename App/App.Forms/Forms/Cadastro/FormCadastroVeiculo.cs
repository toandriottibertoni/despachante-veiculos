using App.Domain.Entidades;
using App.Domain.ObjetosDeValor;
using App.Forms.Enum;
using App.Forms.Forms.Dialog;
using App.Forms.Forms.Pesquisa;
using App.Infra;
using App.Infra.Repositorios;
using System;
using System.Windows.Forms;

namespace App.Forms.Forms.Cadastro
{
    public partial class FormCadastroVeiculo : App.Forms.Forms.Base.Add.FormBaseCadastro
    {
        static UnitOfWork unitOfWork = new UnitOfWork();
        RepositorioVeiculo repositorio = new RepositorioVeiculo(unitOfWork);
        RepositorioCidade repositorioCidade = new RepositorioCidade(unitOfWork);
        RepositorioPessoa repositorioPessoa = new RepositorioPessoa(unitOfWork);
        RepositorioMarca repositorioMarca = new RepositorioMarca(unitOfWork);
        Veiculo entidade = new Veiculo();
        Marca marca = new Marca();
        Pessoa pessoa = new Pessoa();
        Cidade cidade = new Cidade();
        public FormCadastroVeiculo(AcaoForm acaoForm, int id = 0)
        {
            this.acaoForm = acaoForm;
            this.id = id;
            InitializeComponent();
            txtEspecie.DataSource = System.Enum.GetValues(typeof(VeiculoEspecie));
            txtCategoria.DataSource = System.Enum.GetValues(typeof(VeiculoCategoria));
            txtLicenciamento.DataSource = System.Enum.GetValues(typeof(VecimentoLicenciamento));
        }

        private void FormCadastroVeiculo_Load(object sender, EventArgs e)
        {
            if (acaoForm == AcaoForm.Add)
            {
                this.Text = "Incluindo novo Veiculo";
                SolicitarPlaca();
            }
            if (acaoForm == AcaoForm.Update)
                this.Text = "Editando Veiculo [ " + id + " ]";
        }

        void SolicitarPlaca()
        {
            this.Visible = false;
            this.Update();
            FormInput input = new FormInput("ENTRE COM A PLACA", "Digite a Placa para o novo cadastro");
            input.ShowDialog();
            if(input.result == DialogResult.OK)
            {
                VerificarExistencia(input.Value);
                txtPlaca.Text = input.Value;
                this.Visible = true;
            }
            else
            {
                PerguntarParaSair = false;
                this.Close();
            }
        }

        void VerificarExistencia(string placa)
        {
            if (repositorio.IsExist(p => p.Placa.Valor == placa && p.Ativo == true))
            {
                DialogResult result = MessageBox.Show("Já Existe um veiculo com esta placa ativo no sistema, desativa-lo e atualizar dados ?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Veiculo v = repositorio.GetOne(p => p.Placa.Valor == placa && p.Ativo == true);
                    if (v != null)
                    {
                        entidade = v;
                        marca = v.Marca;
                        cidade = v.Endereco.Cidade;
                        PreencherForm();
                        v.Ativo = false;
                        repositorio.Update(v);
                        repositorio.Save();
                        entidade.NomeProprietarioAnterior = v.Pessoa.Nome;
                        entidade.CpfCnpjProprietarioAnterior = v.Pessoa.CpfCnpj;
                        txtNomePropAnterior.Text = v.Pessoa.Nome;
                        txtCpfCnpjPropAnterior.Text = v.Pessoa.CpfCnpj;
                        txtValorCompra.Clear();
                        txtNumeroNotaCompra.Clear();
                        txtDataCompra.Clear();
                        txtEnderecoLogradouro.Clear();
                        txtEnderecoBairro.Clear();
                        txtEnderecoCaixaPostal.Clear();
                        txtEnderecoComplemento.Clear();
                        txtEnderecoNumero.Clear();
                    }
                }
            }
        }

        public override bool add()
        {
            if (entidade.IsInvalid())
            {
                Erros = false;
                ShowErros(entidade.Notifications);
                return false;
            }

            //essa parte do código tem que ser no repositório e não no form
            else if (repositorio.IsExist(p => p.Placa.Valor == entidade.Placa.Valor && p.Ativo == true))
            {
                MessageBox.Show("Já Existe um veiculo com esta placa ativo no sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Erros = false;
                return false;
            }


            else
                return repositorio.Add(entidade);
        }

        public override bool update()
        {
            repositorio.ClearNotifications();
            if (entidade == null) return false;
            if (entidade.IsInvalid())
            {
                Erros = false;
                ShowErros(entidade.Notifications);
                return false;
            }
            bool retorno = repositorio.Update(entidade);
            if (repositorio.IsInvalid())
            {
                Erros = false;
                ShowErros(repositorio.Notifications);
                return false;
            }
            else
            {
                Erros = true;
                return retorno;
            }
        }

        public override bool CarregarEntidadeDoBanco()
        {
            entidade = repositorio.GetOne(p => p.VeiculoId == id);
            cidade = entidade.Endereco.Cidade;
            pessoa = entidade.Pessoa;
            marca = entidade.Marca;
            if (entidade == null) return false;
            else
            {
                PreencherForm();
                return true;
            }
        }

        public override void Save()
        {
            repositorio.Save();
        }

        public override void CarregarEntidadeDoForm()
        {
            entidade.ClearNotifications();
            entidade.Endereco.ClearNotifications();
            cidade.SetValidations();
            pessoa.SetValidations();
            marca.SetValidations();
            Placa placa = new Placa(txtPlaca.Text, TipoPlaca.Comum);
            Endereco endereco = new Endereco(txtEnderecoLogradouro.Text.ToUpper().Trim(), txtEnderecoNumero.Text.ToUpper().Trim(), cidade, txtEnderecoBairro.Text.ToUpper().Trim(), txtEnderecoComplemento.Text.ToUpper().Trim(), txtEnderecoCEP.Text.ToUpper().Trim(), txtEnderecoCaixaPostal.Text.ToUpper().Trim());
            VeiculoCategoria categoria = (VeiculoCategoria)txtCategoria.SelectedItem;
            VeiculoEspecie especie = (VeiculoEspecie)txtEspecie.SelectedItem;
            VecimentoLicenciamento licenciamento = (VecimentoLicenciamento)txtLicenciamento.SelectedItem;
            entidade.SetValues(placa,
                txtRenavam.Text.ToUpper().Trim(),
                txtChassi.Text.ToUpper().Trim(),
                txtMotor.Text.ToUpper().Trim(),
                txtAnoFab.Text.ToUpper().Trim(),
                txtAnoMod.Text.ToUpper().Trim(),
                txtDescricaoModelo.Text.ToUpper().Trim(),
                txtEspelho.Text.ToUpper().Trim(),
                txtCombustivel.Text.ToUpper().Trim(),
                txtCor.Text.ToUpper().Trim(),
                categoria,
                especie,
                licenciamento,
                endereco,
                pessoa,
                marca,
                metroCheckBox1.Checked,
                txtNomePropAnterior.Text.Trim().ToUpper(),
                txtCpfCnpjPropAnterior.Text.Trim().ToUpper(),
                txtDataCompra.Text.Trim().ToUpper().ToUpper(),
                txtValorCompra.Text.Trim().ToUpper(),
                txtNumeroNotaCompra.Text.Trim().ToUpper());
            entidade.NomeComprador = txtCompradorNome.Text.Trim().ToUpper();
            entidade.CpfCnpjComprador = txtCompradorCpfCnpj.Text.Trim().ToUpper();
            entidade.DataVenda = txtCompradorData.Text.Trim().ToUpper();
            entidade.ValorVenda = txtCompradorValor.Text.Trim().ToUpper();


        }
        public override void PreencherForm()
        {
            txtPlaca.Text = entidade.Placa.Valor;
            txtRenavam.Text = entidade.Renavam;
            txtChassi.Text = entidade.Renavam;
            txtMotor.Text = entidade.Motor;
            txtAnoFab.Text = entidade.AnoFab;
            txtAnoMod.Text = entidade.AnoModelo;
            txtDescricaoModelo.Text = entidade.DescricaoModelo;
            txtEspelho.Text = entidade.Espelho;
            txtCombustivel.Text = entidade.Combustivel;
            txtCor.Text = entidade.Cor;
            txtCategoria.SelectedItem = entidade.Categoria;
            txtEspecie.SelectedItem = entidade.Especie;
            txtLicenciamento.SelectedItem = entidade.Licenciamento;
            txtEnderecoLogradouro.Text = entidade.Endereco.Logradouro;
            txtEnderecoNumero.Text = entidade.Endereco.Numero;
            txtEnderecoBairro.Text = entidade.Endereco.Bairro;
            txtEnderecoComplemento.Text = entidade.Endereco.Complemento;
            txtEnderecoCEP.Text = entidade.Endereco.Cep;
            txtEnderecoCaixaPostal.Text = entidade.Endereco.CaixaPostal;
            metroCheckBox1.Checked = entidade.Ativo;
            txtNomePropAnterior.Text = entidade.NomeProprietarioAnterior;
            txtCpfCnpjPropAnterior.Text = entidade.CpfCnpjProprietarioAnterior;
            txtDataCompra.Text = entidade.DataDaCompra;
            txtValorCompra.Text = entidade.ValorDaCompra;
            txtNumeroNotaCompra.Text = entidade.NumeroDaNotaDeCompra;
            txtCompradorNome.Text = entidade.NomeComprador;
            txtCompradorValor.Text = entidade.ValorVenda;
            txtCompradorData.Text = entidade.DataVenda;
            txtCompradorCpfCnpj.Text = entidade.CpfCnpjComprador;
            if (cidade != null)
                txtEnderecoCidade.Text = cidade.Nome + "-" + cidade.Uf;
            if (marca != null)
                txtMarca.Text = marca.Nome;
            if (pessoa != null)
            {
                txtProprietario.Text = pessoa.Nome;
                txtCpfCnpj.Text = pessoa.CpfCnpj;
            }

        }

        private void btSelecionarCidade_Click_1(object sender, EventArgs e)
        {
            FormPesquisaCidade form = new FormPesquisaCidade();
            form.ShowDialog();
            if (form.Id_selecionado > 0)
            {
                repositorioCidade = new RepositorioCidade(unitOfWork);
                repositorioCidade.ClearNotifications();
                cidade = repositorioCidade.GetOne(p => p.CidadeId == form.Id_selecionado);
                txtEnderecoCidade.Text = cidade.Nome + "-" + cidade.Uf;
                if (repositorioCidade.IsInvalid())
                {
                    Erros = true;
                    ShowErros(repositorio.Notifications);
                }
            }
            else
            {
                cidade = new Cidade();
                txtEnderecoCidade.Clear();
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            FormPesquisaPessoa form = new FormPesquisaPessoa();
            form.ShowDialog();
            if (form.Id_selecionado > 0)
            {
                repositorioPessoa = new RepositorioPessoa(unitOfWork);
                repositorioPessoa.ClearNotifications();
                pessoa = repositorioPessoa.GetOne(p => p.PessoaId == form.Id_selecionado);
                txtProprietario.Text = pessoa.Nome;
                txtCpfCnpj.Text = pessoa.CpfCnpj;
                metroButton3.Enabled = true;
                if (repositorioPessoa.IsInvalid())
                {
                    Erros = true;
                    ShowErros(repositorio.Notifications);
                }
            }
            else
            {
                pessoa = new Pessoa();
                txtProprietario.Clear();
                txtCpfCnpj.Clear();
                metroButton3.Enabled = false;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FormPresquisaMarca form = new FormPresquisaMarca();
            form.ShowDialog();
            if (form.Id_selecionado > 0)
            {
                repositorioMarca = new RepositorioMarca(unitOfWork);
                repositorioMarca.ClearNotifications();
                marca = repositorioMarca.GetOne(p => p.MarcaId == form.Id_selecionado);
                txtMarca.Text = marca.Nome;
                if (repositorioPessoa.IsInvalid())
                {
                    Erros = true;
                    ShowErros(repositorio.Notifications);
                }
            }
            else
            {
                marca = new Marca();
                txtMarca.Clear();
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void UsarEnderecoProprietarioNoVeiculo()
        {
            if (pessoa != null)
            {
                txtEnderecoLogradouro.Text = pessoa.Endereco.Logradouro;
                txtEnderecoNumero.Text = pessoa.Endereco.Numero;
                txtEnderecoBairro.Text = pessoa.Endereco.Bairro;
                txtEnderecoComplemento.Text = pessoa.Endereco.Complemento;
                txtEnderecoCEP.Text = pessoa.Endereco.Cep;
                txtEnderecoCaixaPostal.Text = pessoa.Endereco.CaixaPostal;
                cidade = pessoa.Endereco.Cidade;
                if (cidade != null)
                    txtEnderecoCidade.Text = cidade.Nome + "-" + cidade.Uf;
            }
        }

        private void chkEnderecoPropToVeiculo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            UsarEnderecoProprietarioNoVeiculo();
        }

        private void txtValorCompra_Leave(object sender, EventArgs e)
        {
            txtValorCompra.Text = txtValorCompra.Text.Replace(",", "").Replace(".", "").Replace(" ","").Replace("R$","");
            if(txtValorCompra.Text.Length > 0)
            txtValorCompra.Text = Convert.ToDouble(txtValorCompra.Text).ToString("C");
        }

        private void txtCpfCnpjPropAnterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void txtValorCompra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCompradorValor_Leave(object sender, EventArgs e)
        {
            txtCompradorValor.Text = txtCompradorValor.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Replace("R$", "");
            if (txtCompradorValor.Text.Length > 0)
                txtCompradorValor.Text = Convert.ToDouble(txtCompradorValor.Text).ToString("C");
        }

        private void txtCompradorValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void txtCompradorCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
