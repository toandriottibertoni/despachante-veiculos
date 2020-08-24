using App.Domain.Entidades;
using App.Forms.Forms.Cadastro;
using App.Infra;
using App.Infra.Repositorios;
using System;
using System.Windows.Forms;

namespace App.Forms.Forms.Pesquisa
{
    public partial class FormPesquisaCidade : App.Forms.Forms.Base.Pesquisa.FormPesquisaBase
    {
        RepositorioCidade repositorio = new RepositorioCidade(new UnitOfWork());
        public FormPesquisaCidade()
        {
            InitializeComponent();
        }

        private void FormPesquisaCidade_Load(object sender, EventArgs e)
        {
            metroGrid1.AutoGenerateColumns = false;
        }
        protected override void Pesquisar()
        {
            metroGrid1.AutoGenerateColumns = false;
            repositorio = new RepositorioCidade(new UnitOfWork());
            metroGrid1.DataSource = null;
            metroGrid1.DataSource = repositorio.Get(p => p.Nome.Contains(txtBusca.Text));
            LblTotal.Text = "Total: " + metroGrid1.RowCount.ToString();

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
            FormCadastroCidade form = new FormCadastroCidade(Enum.AcaoForm.Add);
            form.ShowDialog();
            Pesquisar();
        }

        protected override void BtUpdate()
        {
            if (SelecionarId(metroGrid1) && Id_selecionado > 0)
            {
                FormCadastroCidade form = new FormCadastroCidade(Enum.AcaoForm.Update, Id_selecionado);
                form.ShowDialog();
                Pesquisar();
            }

        }

        protected override void BtExcluir()
        {
            if (SelecionarId(metroGrid1) && Id_selecionado > 0)
            {
                repositorio.ClearNotifications();
                Cidade item = repositorio.GetOne(p => p.CidadeId == Id_selecionado);
                DialogResult result = MessageBox.Show("Deseja realmente exluir ?", "Excluir ?\n " + item.CidadeId + " " + item.Nome + "-" + item.Uf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    repositorio.Delete(Id_selecionado);
                    if (repositorio.IsInvalid())
                    {
                        foreach (var msg in repositorio.Notifications)
                        {
                            MessageBox.Show(msg.Message, "ERRO", MessageBoxButtons.OK);
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

    }
}
