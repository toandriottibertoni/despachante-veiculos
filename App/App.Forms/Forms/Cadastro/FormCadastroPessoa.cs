using App.Domain.Entidades;
using App.Domain.ObjetosDeValor;
using App.Forms.Enum;
using App.Forms.Forms.Pesquisa;
using App.Infra;
using App.Infra.Repositorios;
using System;
using System.Windows.Forms;
namespace App.Forms.Forms.Cadastro
{
    public partial class FormCadastroPessoa : App.Forms.Forms.Base.Add.FormBaseCadastro
    {
        static UnitOfWork unitOfWork = new UnitOfWork();
        RepositorioPessoa repositorio = new RepositorioPessoa(unitOfWork);
        RepositorioCidade repositorioCidade = new RepositorioCidade(unitOfWork);
        Pessoa entidade = new Pessoa();
        Cidade cidade = new Cidade();

        public FormCadastroPessoa(AcaoForm acaoForm, int id = 0)
        {
            this.acaoForm = acaoForm;
            this.id = id;
            InitializeComponent();
            cidade.SetValidations();
        }

        private void FormCadastroPessoa_Load(object sender, EventArgs e)
        {
            this.Text = "Incluindo nova Pessoa";
            if (acaoForm == AcaoForm.Update)
                this.Text = "Editando Pessoa [" + id + "]";
        }

        public override bool add()
        {
            if (entidade.IsInvalid())
            {
                Erros = false;
                ShowErros(entidade.Notifications);
                return false;
            }
            else if (repositorio.IsExist(p => p.CpfCnpj == entidade.CpfCnpj))
            {
                if (entidade.TipoPessoa == TipoPessoa.Fisica)
                    MessageBox.Show("Já Existe uma pessoa Física com este CPF", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Já Existe uma pessoa Juridica com este CNPJ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            entidade.ClearNotifications();
            entidade = repositorio.GetOne(p => p.PessoaId == id);
            if(entidade.Endereco.Cidade != null)
            cidade = entidade.Endereco.Cidade;
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
            Endereco endereco = new Endereco(
                txtEnderecoLogradouro.Text,
                txtEnderecoNumero.Text,
                cidade,
                txtEnderecoBairro.Text,
                txtEnderecoComplemento.Text,
                txtEnderecoCEP.Text,
                txtEnderecoCaixaPostal.Text);
           // endereco.SetValidations();
            TipoPessoa tipoPessoa = TipoPessoa.Fisica;
            if (rdPj.Checked)
                tipoPessoa = TipoPessoa.Juridica;

            string vencCNH = "";
            txtCnhValidade.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            vencCNH = txtCnhValidade.Text; //texto não formatado
            txtCnhValidade.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação
            if (vencCNH.Length == 8)
            {
                vencCNH = txtCnhValidade.Text;
            }
            else
                vencCNH = "";
            Cnh cnh = new Cnh(
                txtCnhRegistro.Text,
                vencCNH,
                txtCnhLetra.Text);

            entidade.SetValues(
                txtNome.Text,
                txtCpfCnpj.Text,
                txtRgIe.Text,
                endereco,
                tipoPessoa,
                txtNomePai.Text,
                txtNomeMae.Text,
                txtDataNascimento.Text,
                cnh,
                txtTelefone1.Text,
                txtTelefone2.Text);
        }
        public override void PreencherForm()
        {
           // cidade.ClearNotifications();
            txtNome.Text = entidade.Nome;
            txtCpfCnpj.Text = entidade.CpfCnpj;
            txtRgIe.Text = entidade.RgIe;
            if (entidade.TipoPessoa == TipoPessoa.Juridica)
            {
                rdPj.Checked = true;
                rdPf.Checked = false;
            }
            else
            {
                rdPj.Checked = false;
                rdPf.Checked = true;
            }
            if (cidade != null)
            {
                txtEnderecoCidade.Text = cidade.Nome + "-" + cidade.Uf;
            }
            //else
            //{
            //    //para evitar erro instancia novamente a cidade
            //    cidade = new Cidade();
            //}
               
            txtEnderecoLogradouro.Text = entidade.Endereco.Logradouro;
            txtEnderecoNumero.Text = entidade.Endereco.Numero;
            txtEnderecoBairro.Text = entidade.Endereco.Bairro;
            txtEnderecoComplemento.Text = entidade.Endereco.Complemento;
            txtEnderecoCEP.Text = entidade.Endereco.Cep;
            txtEnderecoCaixaPostal.Text = entidade.Endereco.CaixaPostal;
            txtTelefone1.Text = entidade.Telefone1;
            txtTelefone2.Text = entidade.Telefone2;
            if (entidade.Cnh != null)
            {
                txtCnhLetra.Text = entidade.Cnh.Letra;
                txtCnhRegistro.Text = entidade.Cnh.Registro;
                if (entidade.Cnh.Validade != null)
                {
                    txtCnhValidade.Text = entidade.Cnh.Validade.Value.ToString("dd/MM/yyyy");
                }
            }
            txtDataNascimento.Text = entidade.DataNascimento;
            txtNomeMae.Text = entidade.NomeMae;
            txtNomePai.Text = entidade.NomePai;
            }

        private void txtCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void txtRgIe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void txtEnderecoCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void btSelecionarCidade_Click(object sender, EventArgs e)
        {
            FormPesquisaCidade form = new FormPesquisaCidade();
            form.ShowDialog();
            if (form.Id_selecionado > 0)
            {
                repositorioCidade = new RepositorioCidade(unitOfWork);
                repositorioCidade.ClearNotifications();
                cidade = repositorioCidade.GetOne(p => p.CidadeId == form.Id_selecionado);
                txtEnderecoCidade.Text = cidade.Nome + "-" + cidade.Uf;
                if (repositorio.IsInvalid())
                {
                    Erros = true;
                    ShowErros(repositorio.Notifications);
                }
            }
            else
            {
                txtEnderecoCidade.Clear();
            }
        }
    }
}
