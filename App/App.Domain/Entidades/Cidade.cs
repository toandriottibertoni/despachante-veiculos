using App.Domain.Entidades.Base;

namespace App.Domain.Entidades
{
    public class Cidade : EntidadeBase
    {
        public Cidade()
        {
        } //construtor para o EF

        public void SetValues(string nome, string uf)
        {
            this.Nome = nome.Trim().ToUpper();
            this.Uf = uf.Trim().ToUpper();
            SetValidations();
        }

        public void SetValidations()
        {
            this.ClearNotifications();
            //validação de campos especificos
            if (string.IsNullOrWhiteSpace(this.Nome))
                AddNotification("Nome", "O nome da cidade infromado está inválido");
            if (string.IsNullOrWhiteSpace(this.Uf))
                AddNotification("UF", "O UF da cidade infromado está inválido");
        }

        public int CidadeId { get; private set; }
        public string Nome { get; private set; }
        public string Uf { get; private set; }

    }
}