using App.Domain.Entidades;
using App.Forms.Forms.Cadastro;
using App.Infra;
using App.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.Forms.Forms.Pesquisa
{
    public partial class FormPresquisaMarca : App.Forms.Forms.Base.Pesquisa.FormPesquisaBase
    {
        RepositorioMarca repositorio = new RepositorioMarca(new UnitOfWork());

        public FormPresquisaMarca()
        {
            InitializeComponent();
        }

        private void FormPresquisaMarca_Load(object sender, EventArgs e)
        {
        }

        protected override void Pesquisar()
        {
            metroGrid1.AutoGenerateColumns = false;
            repositorio = new RepositorioMarca(new UnitOfWork());
            repositorio.ClearNotifications();
            metroGrid1.DataSource = null;
            metroGrid1.DataSource = repositorio.Get(p => p.Nome.Contains(txtBusca.Text));
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
            FormCadastroMarca form = new FormCadastroMarca(Enum.AcaoForm.Add);
            form.ShowDialog();
            Pesquisar();
        }

        protected override void BtUpdate()
        {
            if (SelecionarId(metroGrid1) && Id_selecionado > 0)
            {
                FormCadastroMarca form = new FormCadastroMarca(Enum.AcaoForm.Update, Id_selecionado);
                form.ShowDialog();
                Pesquisar();
            }

        }
        protected override void BtExcluir()
        {
            if (SelecionarId(metroGrid1) && Id_selecionado > 0)
            {
                repositorio.ClearNotifications();
                Marca item = repositorio.GetOne(p => p.MarcaId == Id_selecionado);
                DialogResult result = MessageBox.Show("Deseja realmente exluir ?", "Excluir ?\n " + item.MarcaId + " " + item.Nome + "-" + item.Sigla, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
