using App.Domain.Entidades;
using App.Forms.Enum;
using App.Infra;
using App.Infra.Repositorios;
using System;
using System.Windows.Forms;

namespace App.Forms.Forms.Cadastro
{
    public partial class FormCadastroMarca : App.Forms.Forms.Base.Add.FormBaseCadastro
    {
        RepositorioMarca repositorio = new RepositorioMarca(new UnitOfWork());
        Marca entidade = new Marca();

        public FormCadastroMarca(AcaoForm acaoForm, int id = 0)
        {
            this.acaoForm = acaoForm;
            this.id = id;
            InitializeComponent();
        }

        private void FormCadastroMarca_Load(object sender, EventArgs e)
        {
            this.Text = "Incluindo nova Marca";
            if (acaoForm == AcaoForm.Update)
                this.Text = "Editando Marca [" + id + "]";
        }
        public override bool add()
        {
            if (entidade.IsInvalid())
            {
                Erros = false;
                ShowErros(entidade.Notifications);
                return false;
            }
            else if (repositorio.IsExist(p => p.Nome == entidade.Nome))
            {
                MessageBox.Show("Já Existe uma Marca com este nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bool retorno = repositorio.Update(entidade);
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
            entidade = repositorio.GetOne(p => p.MarcaId == id);
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
            entidade.SetValues(txtNome.Text.ToUpper().Trim(), txtSigla.Text.ToUpper().Trim());
        }
        public override void PreencherForm()
        {
            txtNome.Text = entidade.Nome;
            txtSigla.Text = entidade.Sigla;
        }
    }
}
