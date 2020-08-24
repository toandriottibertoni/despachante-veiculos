using prmToolkit.NotificationPattern;
using System;
using System.Text.RegularExpressions;

namespace App.Domain.ObjetosDeValor
{
    public class Placa : Notifiable
    {
        //Regex regex = new Regex("^[a-zA-Z]{3}[0-9]{4}$");
        //Regex regexPlacaMercosul = new Regex("/^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$/");
        //Regex regexPlacaMotoMercosul = new Regex("^[a-zA-Z]{3}[0-9]{2}[a-zA-Z]{1}[0-9]");
        public Placa(){}

        public Placa(string Valor, TipoPlaca Tipo)
        {
            this.Valor = Valor.Trim().ToUpper();
            this.Tipo = Tipo;
            //validação de campos
            //new AddNotifications<Placa>(this).IfNullOrWhiteSpace(p => p.Valor);
            //if (string.IsNullOrWhiteSpace(Valor))
            //    AddNotification("Placa", "Placa não foi informada");
            //else if(!regex.IsMatch(this.Valor))
            //{
            //    AddNotification("Placa", "Placa informada é inválida");
            //}
            //else if (!regexPlacaMercosul.IsMatch(this.Valor))
            //{
            //    AddNotification("Placa", "Placa informada é inválida");
            //}
            //else if (!regexPlacaMotoMercosul.IsMatch(this.Valor))
            //{
            //    AddNotification("Placa", "Placa informada é inválida");
            //}
        }
        
        public string Valor { get; private set; }
        public TipoPlaca Tipo { get; private set; }
    }
}