using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Forms.Entidades.Relatorios
{
    public class Relacao
    {
        public int Id { get; set; }
        public string Proprietario { get; set; }
        public string CpfCnpj { get; set; }
        public string Placa { get; set; }
        public string DescricaoVeiculo { get; set; }
        public string Renamvam { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
    }
}
