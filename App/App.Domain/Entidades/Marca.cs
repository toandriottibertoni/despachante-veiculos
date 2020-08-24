using App.Domain.Entidades.Base;
using prmToolkit.NotificationPattern;
namespace App.Domain.Entidades
{
	public class Marca : EntidadeBase
	{
        public Marca()
        {
           
        } //construtor para EF

        public void SetValues(string nome, string sigla)
        {            
            this.Nome = nome.Trim().ToUpper();
            this.Sigla = sigla.Trim().ToUpper();
            SetValidations();
        }

        public void SetValidations()
        {
            ClearNotifications();
            if (string.IsNullOrWhiteSpace(this.Nome))
                AddNotification("Marca", "O Nome da Marca Informado é inválido");
        }

        public int MarcaId { get; private set; }
        public string Nome {get; private set;}
		public string Sigla {get; private set;}
	}
}