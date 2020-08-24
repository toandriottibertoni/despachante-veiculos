using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms.Forms.Erro
{
    public partial class FormErros : MetroFramework.Forms.MetroForm
    {
        List<string> Erros = new List<string>();
        public FormErros(List<string> Erros)
        {
            this.Erros = Erros;
            InitializeComponent();
        }

        private void FormErros_Load(object sender, EventArgs e)
        {
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormErros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void FormErros_Shown(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.DataSource = Erros;
            lblTotal.Text = "Total: " + listBox1.Items.Count.ToString();
        }
    }
}
