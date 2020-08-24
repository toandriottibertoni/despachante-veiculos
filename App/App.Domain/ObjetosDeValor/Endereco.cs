using App.Domain.Entidades;
using App.Domain.Entidades.Base;
using prmToolkit.NotificationPattern;

namespace App.Domain.ObjetosDeValor
{

    //Este item é usado como objeto de valor, não será usado como uma entidade
    public class Endereco : Notifiable
    {
        public Endereco(){
        } //construtor para EF
        public Endereco(string logradouro, string numero, Cidade cidade, string bairro="", string complemento="", string cep="", string caixaPostal="")
        {
            this.Logradouro = logradouro.Trim().ToUpper();
            this.Numero = numero.Trim().ToUpper();
            this.Bairro = bairro.Trim().ToUpper();
            this.Complemento = complemento.Trim().ToUpper();
            this.Cep = cep;
            this.CaixaPostal = caixaPostal.Trim().ToUpper();
            this.Cidade = cidade;
            SetValidations();
        }

        public void SetValidations()
        {
            //validação dos campos especificos
            //para que um endereço seja válido, é necessário informar pelo menos uma rua, um numero e uma cidade

            if (string.IsNullOrWhiteSpace(this.Logradouro))
                AddNotification("Logradouro", "O Logradouro informado é inválido");
            if (string.IsNullOrWhiteSpace(this.Numero))
                AddNotification("Numero", "O Numero informado é inválido");
            if (this.Cidade == null)
                this.Cidade = new Cidade();
            AddNotifications(this.Cidade);
        }

		public string Logradouro {get; private set;}
		public string Numero {get; private set;}
		public string Bairro {get; private set;}
		public string Complemento {get; private set;}
		public string Cep {get; private set;}
		public string CaixaPostal {get; private set;}
		public Cidade Cidade {get; private set;}
	}
}