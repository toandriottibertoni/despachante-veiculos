using System;
using App.Domain.Entidades;
using System.Linq;
using App.Infra.Persistencia.EF;
using App.Domain.ObjetosDeValor;
using App.Infra.Repositorios;
using App.Infra;

namespace Integracao
{
    class Program
    {
        static void Main(string[] args)
        {
            //EfContexto contexto = new EfContexto();
            Cidade cidade = new Cidade();
           // cidade.SetValues("Pacamebu", "SP");
            UnitOfWork unitOfWork = new UnitOfWork();
            RepositorioCidade REPO = new RepositorioCidade(unitOfWork);
            //if (cidade.IsValid())
            //{
            //    REPO.Add(cidade);
            //    REPO.Save();
            //}
            ////var cidade = contexto.Cidades.Where(p => p.Uf == "SP").Single();
            //Console.WriteLine(cidade.Nome);
            //Endereco endereco = new Endereco("Rua dos bobos", "0", cidade);
            //Pessoa pessoa = new Pessoa("TOMAS", "42001179839", "", endereco, TipoPessoa.Fisica);
            //contexto.Pessoas.Add(pessoa);
            //var pessoa  = contexto.Pessoas.Where(p => p.Nome == "TOMAS").Single();
            cidade = REPO.GetOne(p => p.Nome == "Pacaembu");
            Console.WriteLine(cidade.CidadeId + " " + cidade.Nome + " " + cidade.Uf);
            //cidade.SetValues("Pacaembu", cidade.Uf);
            //if (cidade.IsValid())
            //{
            //    REPO.Update(cidade);
            //    REPO.Save();
            //}
            Console.ReadKey();
        }
    }
}
