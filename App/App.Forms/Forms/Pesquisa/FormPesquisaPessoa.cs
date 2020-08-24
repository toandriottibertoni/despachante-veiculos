using App.Domain.Entidades;
using App.Forms.Entidades.Relatorios;
using App.Forms.Forms.Cadastro;
using App.Infra;
using App.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace App.Forms.Forms.Pesquisa
{
    public partial class FormPesquisaPessoa : App.Forms.Forms.Base.Pesquisa.FormPesquisaBase
    {
        RepositorioPessoa repositorio = new RepositorioPessoa(new UnitOfWork());
        List<MenuPessoa> listRelacao;
        public FormPesquisaPessoa()
        {
            InitializeComponent();
        }

        private void FormPesquisaPessoa_Load(object sender, EventArgs e)
        {
            metroGrid1.AutoGenerateColumns = false;
        }

        protected override void Pesquisar()
        {
            metroGrid1.AutoGenerateColumns = false;
            listRelacao = new List<MenuPessoa>();
            repositorio = new RepositorioPessoa(new UnitOfWork());
            repositorio.ClearNotifications();
            metroGrid1.DataSource = null;
            var list = repositorio.GetAll();
            list = list.Where(p => p.Nome.Contains(txtBusca.Text) && p.CpfCnpj.Contains(txtCpfCnpj.Text)).ToList();
            foreach (var item in list)
            {
                listRelacao.Add(new MenuPessoa { id = item.PessoaId, nome = item.Nome, cpfCnpj = item.CpfCnpj });
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
            FormCadastroPessoa form = new FormCadastroPessoa(Enum.AcaoForm.Add);
            form.ShowDialog();
            Pesquisar();
        }

        protected override void BtUpdate()
        {
            if (SelecionarId(metroGrid1) && Id_selecionado > 0)
            {
                FormCadastroPessoa form = new FormCadastroPessoa(Enum.AcaoForm.Update, Id_selecionado);
                form.ShowDialog();
                Pesquisar();
            }

        }
        protected override void BtExcluir()
        {
            if (SelecionarId(metroGrid1) && Id_selecionado > 0)
            {
                repositorio.ClearNotifications();
                Pessoa item = repositorio.GetOne(p => p.PessoaId == Id_selecionado);
                DialogResult result = MessageBox.Show("Excluir ?\n " + item.PessoaId + " " + item.Nome + "-" + item.CpfCnpj, "Deseja realmente exluir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
