using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Forms.Entidades.Relatorios
{
    public class ListaFicha
    {
        public string data { get; set; }
        public string historico { get; set; }
        public string debito { get; set; }
        public string credito { get; set; }
        public double saldo { get; set; }
        public string SaldoString { get; set; }
    }
}
