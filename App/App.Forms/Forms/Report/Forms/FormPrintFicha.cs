using App.Domain.Entidades;
using App.Domain.ObjetosDeValor;
using App.Forms.Entidades.Relatorios;
using App.Infra;
using App.Infra.Repositorios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;

namespace App.Forms.Forms.Report.Forms
{

    public partial class FormPrintFicha : App.Forms.Forms.Base.Geral.FormBaseGeral
    {
        RepositorioVeiculo repositorio = new RepositorioVeiculo(new UnitOfWork());
        Veiculo veiculo = null;
        AcaoReport acao;
        public FormPrintFicha()
        {
            InitializeComponent();
            Imprimir.Enabled = false;
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            veiculo = repositorio.GetOne(p => p.Placa.Valor == txtPlaca.Text && p.Ativo == true);
            Preencher();
        }

        void Preencher()
        {
            if (veiculo != null)
            {
                lblPropNome.Text = veiculo.Pessoa.Nome;
                lblCpfCnpj.Text = veiculo.Pessoa.CpfCnpj;
                lblRenavam.Text = veiculo.Renavam;
                lblDescricao.Text = veiculo.DescricaoModelo;
                lblCor.Text = veiculo.Cor;
                lblCategoria.Text = System.Enum.GetName(typeof(VeiculoCategoria), veiculo.Categoria);
                lblEspecie.Text = System.Enum.GetName(typeof(VeiculoEspecie), veiculo.Especie);
                Imprimir.Enabled = true;
                btPDF.Enabled = true;
                metroButton3.Enabled = true;
                metroButton2.Enabled = true;
            }
            else
            {
                ClearLbl();
                // MessageBox.Show("Veiculo não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlaca.Clear();
                txtPlaca.Focus();
            }

        }

        private void FormPrintFicha_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            acao = AcaoReport.Imprimir;
            Carregar();
        }

        void Carregar()
        {
            this.reportViewer1.Clear();
            this.reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", listaFicha));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Placa", veiculo.Placa.Valor));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Renavam", veiculo.Renavam));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Chassi", veiculo.Chassi));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("AnoFab", veiculo.AnoFab));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("AnoMod", veiculo.AnoModelo));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cor", veiculo.Cor));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Combustivel", veiculo.Combustivel));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Marca", veiculo.Marca.Nome));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Descricao", veiculo.DescricaoModelo));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Categoria", veiculo.Categoria.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Especie", veiculo.Especie.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Proprietario", veiculo.Pessoa.Nome));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CpfCnpj", veiculo.Pessoa.CpfCnpj));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Endereco", veiculo.Pessoa.Endereco.Logradouro + ", N°.:" + veiculo.Pessoa.Endereco.Numero + ", " + veiculo.Pessoa.Endereco.Bairro));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cidade", veiculo.Pessoa.Endereco.Cidade.Nome + "-" + veiculo.Pessoa.Endereco.Cidade.Uf));
            this.reportViewer1.RefreshReport();
            this.Focus();
            txtPlaca.Clear();
            txtPlaca.Focus();
            Imprimir.Enabled = false;
        }


        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            if (veiculo != null)
            {
                if (acao == AcaoReport.Imprimir)
                {
                    this.reportViewer1.PrintDialog();
                }
                else if (acao == AcaoReport.SalvarWord)
                {
                    this.reportViewer1.ExportDialog(reportViewer1.LocalReport.ListRenderingExtensions()[5]);
                }
                else if (acao == AcaoReport.SalvarPDF)
                {
                    this.reportViewer1.ExportDialog(reportViewer1.LocalReport.ListRenderingExtensions()[3]);
                }
                else if (acao == AcaoReport.SalverExcel)
                {
                    this.reportViewer1.ExportDialog(reportViewer1.LocalReport.ListRenderingExtensions()[1]);
                }
                txtPlaca.Focus();
                ClearLbl();
                this.Focus();
                veiculo = null;
                txtPlaca.Clear();
                txtPlaca.Focus();
                Imprimir.Enabled = false;
                metroButton3.Enabled = false;
                btPDF.Enabled = false;
                metroButton3.Enabled = false;
                metroButton2.Enabled = false;
            }
        }

        void ClearLbl()
        {
            lblPropNome.Text = "";
            lblCpfCnpj.Text = "";
            lblRenavam.Text = "";
            lblDescricao.Text = "";
            lblCor.Text = "";
            lblCategoria.Text = "";
            lblEspecie.Text = "";
        }

        private void txtPlaca_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void txtPlaca_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Preencher();
        }
                                   
        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            acao = AcaoReport.SalvarWord;
            Carregar();
        }

        private void btPDF_Click(object sender, EventArgs e)
        {
            acao = AcaoReport.SalvarPDF;
            Carregar();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            acao = AcaoReport.SalverExcel;
            Carregar();
        }
    }

    public enum AcaoReport
    {
        Imprimir,
        SalvarWord,
        SalvarPDF,
        SalverExcel
    }
}
