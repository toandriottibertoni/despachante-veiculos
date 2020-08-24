using App.Domain.Entidades;
using App.Forms.Entidades.Relatorios;
using App.Infra;
using App.Infra.Repositorios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace App.Forms.Forms.Report.Forms
{
    public partial class FormReportCNH : App.Forms.Forms.Base.Geral.FormBaseGeral
    {
        List<RelacaoCNH> listRelacao = new List<RelacaoCNH>();
        public FormReportCNH()
        {
            InitializeComponent();
        }

        private void FormRelatorioCNH_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        void Pesquisar()
        {
            this.reportViewer1.Clear();
            this.reportViewer1.LocalReport.DataSources.Clear();

            string strDtIni, strDtEnd;
            txtIni.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            strDtIni = txtIni.Text; //texto não formatado
            txtIni.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

            txtEnd.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            strDtEnd = txtEnd.Text; //texto não formatado
            txtEnd.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação



            List<Pessoa> list = new List<Pessoa>();

            list = new RepositorioPessoa(new UnitOfWork()).GetAll();// tudo

            list = list.Where(p => p.Cnh.Validade != null).ToList();

            if (strDtIni.Length == 8)
            {
                try
                {
                    list = list.Where(p => p.Cnh.Validade.Value >= Convert.ToDateTime(txtIni.Text)).ToList();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }

            if (strDtEnd.Length == 8)
            {

                try
                {
                    list = list.Where(p => p.Cnh.Validade.Value <= Convert.ToDateTime(txtEnd.Text)).ToList();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

            list = list.Where(p => p.Nome.Contains(txtNome.Text)).ToList();
            foreach (var item in list)
            {
                listRelacao.Add(new RelacaoCNH { CpfCnpj = item.CpfCnpj, Id = item.PessoaId, Letra = item.Cnh.Letra, Proprietario = item.Nome, Registro = item.Cnh.Registro, Telefone1 = item.Telefone1, Telefone2 = item.Telefone2, Validade = item.Cnh.ValidadeToString() });
            }
            load();
        }


        void load()
        {
            //reportViewer1.LocalReport.ReportPath = @"C:\Users\TOMAS\Desktop\Projetos\App\App.Forms\Forms\Report\Modelos\ReportRelacao.rdlc";
            //reportViewer1.LocalReport.EnableExternalImages = true;
            //reportViewer1.LocalReport.EnableHyperlinks = true;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", listRelacao.OrderBy(p => p.Proprietario).ToList()));
            this.reportViewer1.RefreshReport();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            listRelacao.Clear();
            this.reportViewer1.Clear();
            this.reportViewer1.LocalReport.DataSources.Clear();
        }
    }



}
