using App.Domain.Entidades;
using App.Domain.Servicos;
using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace App.Infra.Repositorios
{
    public class RepositorioPessoa : Notifiable, IRepositorioPessoa
    {
        private IUnitOfWork unitOfWork;
        public RepositorioPessoa(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public bool Add(Pessoa Pessoa)
        {
            try
            {
                unitOfWork.Contexto.Pessoas.Add(Pessoa);
                return true;
            }
            catch (Exception e)
            {
                AddNotification("Erro de Add", e.Message);
                return false;
            }
        }

        public bool Delete(int PessoaId)
        {
            try
            {
                Pessoa pessoa = unitOfWork.Contexto.Pessoas.Where(p => p.PessoaId == PessoaId).FirstOrDefault();
                if (pessoa != null)
                {
                    //veirificar pendencias
                    //veiculos
                    int qde = unitOfWork.Contexto.Veiculos.Count(p => p.Pessoa.PessoaId == pessoa.PessoaId);
                    if (qde > 0)
                    {
                        AddNotification("Erro:", "Proprietário Possui " + qde + " pendencias em veiculos");
                        return false;
                    }
                    unitOfWork.Contexto.Pessoas.Remove(pessoa);
                    return true;
                }
                else
                {
                    AddNotification("Erro:", "Pessoa Inexistente na base de dados");
                    return false;
                }
            }
            catch (Exception e)
            {
                AddNotification("Erro de Delete", e.Message);
                return false;
            }
        }

        public List<Pessoa> GetAll()
        {
            try
            {
                return unitOfWork.Contexto.Pessoas.ToList();
            }
            catch (Exception e)
            {
                AddNotification("Erro de GetAll", e.Message);
                return null;
            }
        }

        public Pessoa GetOne(Expression<Func<Pessoa, bool>> condition)
        {
            try
            {
                return unitOfWork.Contexto.Pessoas.Include(p=> p.Endereco.Cidade).Where(condition).FirstOrDefault();
            }
            catch (Exception e)
            {
                AddNotification("Erro de GetOne", e.Message);
                return null;
            }
        }

        public List<Pessoa> Get(Expression<Func<Pessoa, bool>> condition)
        {
            try
            {
                return unitOfWork.Contexto.Pessoas.Where(condition).ToList();
            }
            catch (Exception e)
            {
                AddNotification("Erro de GetWith", e.Message);
                return null;
            }
        }

        public void Save()
        {
            unitOfWork.Save();
        }

        public bool Update(Pessoa pessoa)
        {
            //try
            //{
            //    unitOfWork.Contexto.Pessoas.Update(pessoa);
            //    return true;
            //}
            //catch (Exception e)
            //{
            //    AddNotification("Erro de Update", e.Message);
            //    return false;
            //}
            try
            {
                Pessoa pessoaAux = GetOne(p => p.CpfCnpj == pessoa.CpfCnpj);

                if (pessoaAux != null) // existe uma cidade com este dados
                {
                    // so posso salvar o update se os id forem iguais
                    if (pessoaAux.PessoaId == pessoa.PessoaId)
                    {
                        unitOfWork.Contexto.Pessoas.Update(pessoa);
                        return true;
                    }
                    else
                        AddNotification("Erro de Update", "Já existe um cadastro com este dados, não pode haver duplicidade");
                }
                else // se nao existe uma cidade com este dados entao eu posso salvar
                {
                    unitOfWork.Contexto.Pessoas.Update(pessoa);
                    return true;
                }
                //unitOfWork.Contexto.Cidades.Update(cidade);
                return false;
            }
            catch (Exception e)
            {
                AddNotification("Erro de Update", e.Message);
                return false;
            }
        }

        public bool IsExist(Expression<Func<Pessoa, bool>> condition)
        {
            if (unitOfWork.Contexto.Pessoas.Where(condition).FirstOrDefault() != null)
                return true;
            else return false;
        }
    }
}
