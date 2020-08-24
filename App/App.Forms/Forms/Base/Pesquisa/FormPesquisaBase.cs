using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.Forms.Forms.Base.Pesquisa
{
    public partial class FormPesquisaBase : App.Forms.Forms.Base.Geral.FormBaseGeral
    {
        public int Id_selecionado { get; private set; }
        public FormPesquisaBase()
        {
            InitializeComponent();
            Id_selecionado = 0;
        }

        private void FormPesquisaBase_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        protected virtual void Pesquisar()
        {

        }

        protected virtual void SetDataGrid()
        {

        }

        protected virtual void BtUpdate()
        {

        }

        protected virtual void BtNovo()
        {

        }

        protected virtual void BtExcluir()
        {

        }
        
        protected void SetIdSelecionado(int valor)
        {
            Id_selecionado = valor;
        }

        protected bool SelecionarId(MetroGrid dataGrid)
        {
            if (dataGrid.Rows.Count > 0 && dataGrid.SelectedRows.Count > 0)
            {
                Id_selecionado =  Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                return true;
            }
            Id_selecionado = 0;
            return false;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void FormPesquisaBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            BtNovo();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            BtUpdate();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            BtExcluir();
        }
    }
}
