using App.Domain.Entidades;
using App.Domain.ObjetosDeValor;
using App.Forms.Entidades.Relatorios;
using App.Forms.Forms.Pesquisa;
using App.Infra;
using App.Infra.Repositorios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace App.Forms.Forms.Report.Forms
{
    public partial class FormReportRelacao : App.Forms.Forms.Base.Geral.FormBaseGeral
    {
        List<Relacao> listRelacao = new List<Relacao>();
        Pessoa pessoa = null;

        public FormReportRelacao()
        {
            InitializeComponent();
        }

        private void FormReportRelacao_Load(object sender, EventArgs e)
        {
            txtEspecie.DataSource = System.Enum.GetValues(typeof(VeiculoEspecie));
            txtCategoria.DataSource = System.Enum.GetValues(typeof(VeiculoCategoria));
            txtLicenciamento.DataSource = System.Enum.GetValues(typeof(VecimentoLicenciamento));
            
           // Pesquisar();
        }

        void Pesquisar()
        {
            this.reportViewer1.Clear();
            this.reportViewer1.LocalReport.DataSources.Clear();
            VeiculoCategoria categoria = (VeiculoCategoria)txtCategoria.SelectedItem;
            VeiculoEspecie especie = (VeiculoEspecie)txtEspecie.SelectedItem;
            VecimentoLicenciamento licenciamento = (VecimentoLicenciamento)txtLicenciamento.SelectedItem;

            List<Veiculo> list = new List<Veiculo>();

            list = new RepositorioVeiculo(new UnitOfWork()).GetAll().Where(p=>p.Ativo==true).ToList(); // tudo
            list = list.Where(v => v.Pessoa.Nome.Contains(txtPessoa.Text)).ToList();
            if (categoria != VeiculoCategoria.NaoInformado)
                list = list.Where(v => v.Categoria == categoria).ToList();
            if (especie != VeiculoEspecie.NaoInformado)
                list = list.Where(v => v.Especie == especie).ToList();
            if (licenciamento != VecimentoLicenciamento.NaoInformado)
                list = list.Where(v => v.Licenciamento == licenciamento).ToList();


            foreach (var item in list)
            {
                listRelacao.Add(new Relacao { Id = item.Pessoa.PessoaId, Proprietario = item.Pessoa.Nome, CpfCnpj = item.Pessoa.CpfCnpj, Placa = item.Placa.Valor, DescricaoVeiculo = item.DescricaoModelo, Renamvam = item.Renavam, Telefone1 = item.Pessoa.Telefone1, Telefone2 = item.Pessoa.Telefone2});
            }
            load();
        }

        void load()
        {
            //reportViewer1.LocalReport.ReportPath = @"C:\Users\TOMAS\Desktop\Projetos\App\App.Forms\Forms\Report\Modelos\ReportRelacao.rdlc";
            //reportViewer1.LocalReport.EnableExternalImages = true;
            //reportViewer1.LocalReport.EnableHyperlinks = true;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", listRelacao.OrderBy(p => p.Proprietario).OrderBy(pa => pa.Placa).ToList()));
            this.reportViewer1.RefreshReport();
        }

        private void chkProprietario_CheckedChanged(object sender, EventArgs e)
        {
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormPesquisaPessoa form = new FormPesquisaPessoa();
            form.ShowDialog();
            if (form.Id_selecionado > 0)
            {
                RepositorioPessoa repositorioPessoa = new RepositorioPessoa(new UnitOfWork());
                repositorioPessoa.ClearNotifications();
                pessoa = repositorioPessoa.GetOne(p => p.PessoaId == form.Id_selecionado);
                txtPessoa.Text = pessoa.Nome;
                txtCpfCnpj.Text = pessoa.CpfCnpj;
                if (repositorioPessoa.IsInvalid())
                {
                    foreach (var msg in repositorioPessoa.Notifications)
                    {
                        MessageBox.Show("ERRO", msg.Message, MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                pessoa = null;
                txtPessoa.Clear();
            }
        }

        private void reportViewer1_Resize(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            listRelacao.Clear();
            this.reportViewer1.Clear();
            this.reportViewer1.LocalReport.DataSources.Clear();
        }

        private void btLimparPessoa_Click(object sender, EventArgs e)
        {
            pessoa = null;
            txtPessoa.Clear();
            txtCpfCnpj.Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
        }
    }
}
