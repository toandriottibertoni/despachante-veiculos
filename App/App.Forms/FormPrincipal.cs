using App.Forms.Enum;
using App.Forms.Forms.Backup;
using App.Forms.Forms.Cadastro;
using App.Forms.Forms.Pesquisa;
using App.Forms.Forms.Report.Forms;
using App.Infra;
using App.Infra.Repositorios;
using System;

namespace App.Forms
{
    public partial class FormPrincipal : MetroFramework.Forms.MetroForm
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            RepositorioCidade repositorio = new RepositorioCidade(new UnitOfWork());
            var cidade = repositorio.GetAll();
            cidade = null;
            repositorio = null;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        //private void metroTile1_Click(object sender, EventArgs e)
        //{

        //}

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            FormCadastroVeiculo form = new FormCadastroVeiculo(AcaoForm.Add);
            form.ShowDialog();
        }

        private void cadastroPessoa_Click(object sender, EventArgs e)
        {
            FormCadastroPessoa form = new FormCadastroPessoa(AcaoForm.Add);
            form.ShowDialog();
        }

        private void pesquisaVeiculo_Click(object sender, EventArgs e)
        {
            pesquisaVeiculo.Enabled = false;
            this.Update();
            FormReportRelacao form = new FormReportRelacao();
            form.ShowDialog();
            pesquisaVeiculo.Enabled = true;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            FormCadastroCidade form = new FormCadastroCidade(AcaoForm.Add);
            form.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            FormCadastroMarca form = new FormCadastroMarca(AcaoForm.Add);
            form.ShowDialog();
        }

        private void menuCidade_Click(object sender, EventArgs e)
        {
            FormPesquisaCidade form = new FormPesquisaCidade();
            form.ShowDialog();
        }

        private void menuMarca_Click(object sender, EventArgs e)
        {
            FormPresquisaMarca form = new FormPresquisaMarca();
            form.ShowDialog();
        }

        private void MenuVeiculo_Click(object sender, EventArgs e)
        {
            FormPresquisaVeiculo form = new FormPresquisaVeiculo();
            form.ShowDialog();
        }

        private void menuPessoa_Click(object sender, EventArgs e)
        {
            FormPesquisaPessoa form = new FormPesquisaPessoa();
            form.ShowDialog();
        }

        private void MenuFicha_Click(object sender, EventArgs e)
        {
            FormPrintFicha form = new FormPrintFicha();
            form.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            FormBackup form = new FormBackup(Acao.bakcup);
            form.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            FormReportCNH form = new FormReportCNH();
            form.ShowDialog();
        }
    }
}
