using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.Forms.Forms.Dialog
{
    public partial class FormInput : App.Forms.Forms.Base.Geral.FormBaseGeral
    {
        string Titulo, Menssagem;
        public DialogResult result { get; private set; }
        public string Value {get; private set;}
        public FormInput(string Titulo, string Menssagem)
        {
            InitializeComponent();
            this.Text = Titulo;
            this.txtMenssagem.Text = Menssagem;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Value = txtValor.Text.Trim().ToUpper();
            result = DialogResult.OK;
            this.Close();
        }

        private void FormInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(result != DialogResult.OK)
            result = DialogResult.Cancel;
        }

        private void FormInput_Shown(object sender, EventArgs e)
        {
            txtValor.Focus();
        }

        private void FormInput_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btOk.PerformClick();
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            
        }
    }
}
