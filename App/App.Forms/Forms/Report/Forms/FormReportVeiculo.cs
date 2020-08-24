using App.Domain.Entidades;
using System;

namespace App.Forms.Forms.Report.Forms
{
    public partial class FormReportVeiculo : App.Forms.Forms.Base.Geral.FormBaseGeral
    {
        Veiculo Veiculo = new Veiculo();
        public FormReportVeiculo(Veiculo Veiculo)
        {
            this.Veiculo = Veiculo;
            InitializeComponent();
            Preencher();
        }

        private void FormReportVeiculo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        void Preencher()
        {
            
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Placa", Veiculo.Placa.Valor));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Renavam", Veiculo.Renavam));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Chassi", Veiculo.Chassi));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("AnoFab", Veiculo.AnoFab));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("AnoMod", Veiculo.AnoModelo));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cor", Veiculo.Cor));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Combustivel", Veiculo.Combustivel));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Marca", Veiculo.Marca.Nome));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Descricao", Veiculo.DescricaoModelo));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Endereco", Veiculo.Endereco.Logradouro + ", N°.: " + Veiculo.Endereco.Numero + ", Bairro: "+ Veiculo.Endereco.Bairro ));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cidade", Veiculo.Endereco.Cidade.Nome +"-" + Veiculo.Endereco.Cidade.Uf));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PropNome", Veiculo.Pessoa.Nome));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PropCpfCnpj", Veiculo.Pessoa.CpfCnpj));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PropEndereco", Veiculo.Pessoa.Endereco.Logradouro + ", N°.:" + Veiculo.Pessoa.Endereco.Numero + ", " + Veiculo.Pessoa.Endereco.Bairro));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PropCidade", Veiculo.Pessoa.Endereco.Cidade.Nome + "-" + Veiculo.Pessoa.Endereco.Cidade.Uf));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Categoria", Veiculo.Categoria.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Especie", Veiculo.Especie.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PropAnteriorNome", Veiculo.NomeProprietarioAnterior));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("PropAnteriorCpfCnpj", Veiculo.CpfCnpjProprietarioAnterior));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataCompra", Veiculo.DataDaCompra));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ValorCompra", Veiculo.ValorDaCompra));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NumeroNota", Veiculo.NumeroDaNotaDeCompra));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CompradorNome", Veiculo.NomeComprador));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CpfCnpjComprador", Veiculo.CpfCnpjComprador));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataVenda", Veiculo.DataVenda));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ValorVenda", Veiculo.ValorVenda));
            //PropAnteriorNome]
            this.reportViewer1.RefreshReport();
        }

        private void FormReportVeiculo_Shown(object sender, EventArgs e)
        {
        }
    }
}
