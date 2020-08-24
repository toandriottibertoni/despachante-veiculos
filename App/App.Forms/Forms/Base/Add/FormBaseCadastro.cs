using App.Forms.Enum;
using App.Forms.Forms.Erro;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.Forms.Forms.Base.Add
{
    public partial class FormBaseCadastro : App.Forms.Forms.Base.Geral.FormBaseGeral
    {
        protected AcaoForm acaoForm { get; set; }
        protected int id { get; set; }
        protected bool Erros = true;
        protected bool PerguntarParaSair = true;
        public FormBaseCadastro()
        {
            //this.acaoForm = acaoForm;
            //this.id = id;
            InitializeComponent();
        }

        private void ButtonAction()
        {
            CarregarEntidadeDoForm();
            if (acaoForm == AcaoForm.Add)
            {
                bool resultado = add();
                if (resultado)
                {
                    Save();
                    MessageBox.Show("Sucesso ao realizar Inclusão", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PerguntarParaSair = false;
                    this.Close();
                }
                else if (resultado && Erros)
                {
                    MessageBox.Show("A inclusão não pode ser realizada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PerguntarParaSair = true;
                }
            }
            else if (acaoForm == AcaoForm.Update)
            {
                bool resultado = update();
                if (resultado)
                {
                    Save();
                    MessageBox.Show("Sucesso ao realizar Alteração", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PerguntarParaSair = false;
                    this.Close();
                }
                else if (resultado  == false && Erros)
                {
                    MessageBox.Show("A Alteração não pode ser realizada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PerguntarParaSair = true;
                }
            }
        }

        protected void ShowErros(IReadOnlyCollection<Notification> Erros) // receber lista de erros
        {
            List<string> erro = new List<string>();
            foreach (var item in Erros)
            {
                erro.Add(item.Property + ": " + item.Message);
            }
            FormErros form = new FormErros(erro);
            form.ShowDialog();
        }

        public virtual bool add()
        {
            throw new NotImplementedException();
        }

        public virtual bool update()
        {
            throw new NotImplementedException();
        }

        public virtual bool CarregarEntidadeDoBanco()
        {
            throw new NotImplementedException();
        }

        public virtual void CarregarEntidadeDoForm()
        {
            throw new NotImplementedException();
        }
        public virtual void PreencherForm()
        {

        }

        public virtual void Save()
        {

        }

        private void FormBaseCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //PERGUNTAR PARA SAIR
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ButtonAction();
        }

        private void FormBaseCadastro_Load_1(object sender, EventArgs e)
        {
            if (acaoForm == AcaoForm.Update)
            {
                if (id <= 0)
                {
                    MessageBox.Show("Erro ao Carregar dados, id <= 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool resultado = CarregarEntidadeDoBanco();
                    if (resultado == false)
                    {
                        MessageBox.Show("Erro ao Carregar dados, NULL", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void FormBaseCadastro_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if(PerguntarParaSair)
            {
                DialogResult result = MessageBox.Show("Deseja Realmente Sair ?", "SAIR ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    PerguntarParaSair = false;
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void FormBaseCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                PerguntarParaSair = true;
                this.Close();
            }
        }
    }
}
