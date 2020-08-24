using App.Domain.Entidades;
using App.Forms.Entidades.Relatorios;
using App.Forms.Enum;
using App.Forms.Forms.Cadastro;
using App.Forms.Forms.Report.Forms;
using App.Infra;
using App.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace App.Forms.Forms.Pesquisa
{
    public partial class FormPresquisaVeiculo : App.Forms.Forms.Base.Pesquisa.FormPesquisaBase
    {
        RepositorioVeiculo repositorio = new RepositorioVeiculo(new UnitOfWork());
        List<MenuVeiculo> listRelacao;
        public FormPresquisaVeiculo()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {
            metroGrid1.AutoGenerateColumns = false;
            listRelacao = new List<MenuVeiculo>();
            //para apresentar objetos de valor no grid view tem que se criar outros objetos contento tipos comuns (int, string, float)
            repositorio = new RepositorioVeiculo(new UnitOfWork());
            repositorio.ClearNotifications();
            metroGrid1.DataSource = null;
            var list = repositorio.GetAll();
            if (chkIncluirInativos.Checked == false)
                list = list.Where(p => p.Placa.Valor.Contains(txtBusca.Text) && p.Pessoa.Nome.Contains(txtPropNome.Text) && p.Ativo == true).ToList();
            else
                list = list.Where(p => p.Placa.Valor.Contains(txtBusca.Text) && p.Pessoa.Nome.Contains(txtPropNome.Text)).ToList();
            foreach (var item in list)
            {
                listRelacao.Add(new MenuVeiculo { id = item.VeiculoId, placa = item.Placa.Valor, descricao = item.DescricaoModelo, PropNome = item.Pessoa.Nome, CpfCnpj = item.Pessoa.CpfCnpj });
            }

            metroGrid1.DataSource = listRelacao;
            LblTotal.Text = "Total: " + metroGrid1.RowCount.ToString();
            if (repositorio.IsInvalid())
            {
                foreach (var msg in repositorio.Notifications)
                {
                    MessageBox.Show("ERRO", msg.Message, MessageBoxButtons.OK);
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (SelecionarId(metroGrid1))
                this.Close();
            else
            {
                SetIdSelecionado(0);
            }
        }

        protected override void BtNovo()
        {
            FormCadastroVeiculo form = new FormCadastroVeiculo(AcaoForm.Add);
            form.ShowDialog();
            Pesquisar();
        }

        protected override void BtUpdate()
        {
            if (SelecionarId(metroGrid1) && Id_selecionado > 0)
            {
                FormCadastroVeiculo form = new FormCadastroVeiculo(AcaoForm.Update, Id_selecionado);
                form.ShowDialog();
                Pesquisar();
            }

        }
        protected override void BtExcluir()
        {
            if (SelecionarId(metroGrid1) && Id_selecionado > 0)
            {
                repositorio.ClearNotifications();
                Veiculo item = repositorio.GetOne(p => p.VeiculoId == Id_selecionado);
                DialogResult result = MessageBox.Show("Excluir ?\n ID: " + item.VeiculoId + " PLACA:" + item.Placa.Valor + "\nDE: " + item.Pessoa.Nome, "Deseja realmente exluir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    repositorio.Delete(Id_selecionado);

                    if (repositorio.IsInvalid())
                    {
                        foreach (var msg in repositorio.Notifications)
                        {
                            MessageBox.Show("ERRO", msg.Message, MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        repositorio.Save();
                        Pesquisar();
                    }
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void FormPesquisaVeiculo_Load(object sender, EventArgs e)
        {
            metroGrid1.AutoGenerateColumns = false;
            Pesquisar();

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (SelecionarId(metroGrid1) && Id_selecionado > 0)
            {
                Veiculo v = repositorio.GetOne(p => p.VeiculoId == Id_selecionado);
                FormReportVeiculo form = new FormReportVeiculo(v);
                form.ShowDialog();
            }
        }


        private void FormPresquisaVeiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
