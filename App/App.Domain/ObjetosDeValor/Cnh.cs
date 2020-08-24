using System;

namespace App.Domain.ObjetosDeValor
{
    public class Cnh
    {
        public Cnh()
        {

        }
        public Cnh(string Registro, string Validade, string Letra)
        {


            if (!string.IsNullOrWhiteSpace(Validade))
            {
                this.Validade = Convert.ToDateTime(Validade);
            }
            else
                this.Validade = null;

            this.Registro = Registro.Trim().ToUpper();
            this.Letra = Letra.Trim().ToUpper();
        }
        public string Registro { get; private set; }
        // public string Validade { get; private set; }
        public DateTime? Validade { get; private set; }
        public string Letra { get; private set; }

        public string ValidadeToString()
        {
            if (Validade != null)
                return Validade.Value.ToString("dd/MM/yyyy");
            else
                return "";
        }
    }
}
