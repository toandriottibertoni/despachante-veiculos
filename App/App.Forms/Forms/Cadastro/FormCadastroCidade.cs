using App.Domain.Entidades;
using App.Forms.Enum;
using App.Infra;
using App.Infra.Repositorios;
using System;
using System.Windows.Forms;
namespace App.Forms.Forms.Cadastro
{
    public partial class FormCadastroCidade : App.Forms.Forms.Base.Add.FormBaseCadastro
    {
        RepositorioCidade repositorio = new RepositorioCidade(new UnitOfWork());
        Cidade entidade = new Cidade();
        public FormCadastroCidade(AcaoForm acaoForm, int id = 0)
        {
            this.acaoForm = acaoForm;
            this.id = id;
            InitializeComponent();
        }

        private void FormCadastroCidade_Load(object sender, EventArgs e)
        {
            this.Text = "Incluindo nova Cidade";
            if (acaoForm == AcaoForm.Update)
                this.Text = "Editando Cidade [" + id + "]";
        }
        public override bool add()
        {
            if (entidade.IsInvalid())
            {
                Erros = false;
                ShowErros(entidade.Notifications);
                return false;
            }
            else if(repositorio.IsExist(p=>p.Nome == entidade.Nome && p.Uf == entidade.Uf))
            {
                MessageBox.Show("Já Existe uma cidade com este nome e uf", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Erros = false;
                return false;
            }
            else                
                return repositorio.Add(entidade);
        }

        public override bool update()
        {
            repositorio.ClearNotifications();
            if (entidade == null) return false;
            if (entidade.IsInvalid())
            {
                Erros = false;
                ShowErros(entidade.Notifications);
                return false;
            }
            bool retorno =  repositorio.Update(entidade);
            if (repositorio.IsInvalid())
            {
                Erros = false;
                ShowErros(repositorio.Notifications);
                return false;
            }
            else
            {
                Erros = true;
                return retorno;
            }
        }

        public override bool CarregarEntidadeDoBanco()
        {
            entidade = repositorio.GetOne(p => p.CidadeId == id);
            if (entidade == null) return false;
            else
            {
                PreencherForm();
                return true;
            }
        }

        public override void Save()
        {
            repositorio.Save();
        }

        public override void CarregarEntidadeDoForm()
        {
            entidade.ClearNotifications();
            entidade.SetValues(TxtNome.Text.ToUpper().Trim(), CmbUf.Text.ToUpper().Trim());
        }
        public override void PreencherForm()
        {
            TxtNome.Text = entidade.Nome;
            CmbUf.Text = entidade.Uf;
        }

        private void CmbUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
