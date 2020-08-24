using App.Domain.Entidades.Base;
using App.Domain.ObjetosDeValor;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;

namespace App.Domain.Entidades
{
    public class Pessoa : EntidadeBase
    {
        public Pessoa()
        {
            //SetValidations();
        } //construtor para EF

        public void SetValues(string nome, string cpfCnpj, string rgIe, Endereco endereco, TipoPessoa tipoPessoa, string NomePai, string NomeMae, string DataNascimento, Cnh Cnh, string telefone1, string telefone2)
        {
            this.Nome = nome;
            this.CpfCnpj = cpfCnpj;
            this.RgIe = rgIe.Trim().ToUpper();
            this.Endereco = endereco;
            this.TipoPessoa = tipoPessoa;
            this.NomePai = NomePai.Trim().ToUpper();
            this.NomeMae = NomeMae.Trim().ToUpper();
            this.DataNascimento = DataNascimento.Trim().ToUpper();
            this.Cnh = Cnh;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            SetValidations();
        }

        public void SetValidations()
        {
            //validação de campos
            //o minimo para se cadastrar uma pessoa é nome, cpf e tipo
            new AddNotifications<Pessoa>(this).IfNullOrWhiteSpace(p => p.Nome);
            if (this.TipoPessoa == TipoPessoa.Fisica)
                new AddNotifications<Pessoa>(this).IfNotCpf(p => p.CpfCnpj);
            else if (this.TipoPessoa == TipoPessoa.Juridica)
                new AddNotifications<Pessoa>(this).IfNotCnpj(p => p.CpfCnpj);
            if (this.Endereco == null)
                this.Endereco = new Endereco();

            AddNotifications(this.Endereco);
        }

        public int PessoaId { get; private set; }
        public string Nome { get; private set; }
        public string CpfCnpj { get; private set; }
        public string RgIe { get; private set; }
        public Endereco Endereco { get; private set; }
        public TipoPessoa TipoPessoa { get; private set; }
        public List<Veiculo> Veiculos { get; private set; }
        public string NomePai { get; private set; }
        public string NomeMae { get; private set; }
        public string DataNascimento { get; private set; }
        public Cnh Cnh { get; private set; }
        public string Telefone1 { get; private set; }
        public string Telefone2 { get; private set; }
    }
}