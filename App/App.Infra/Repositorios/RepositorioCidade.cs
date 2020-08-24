using App.Domain.Entidades;
using App.Domain.Servicos;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace App.Infra.Repositorios
{

    public class RepositorioCidade : Notifiable, IRepositorioCidade
    {
        private IUnitOfWork unitOfWork;
        public RepositorioCidade(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public bool Add(Cidade Cidade)
        {
            try
            {
                unitOfWork.Contexto.Cidades.Add(Cidade);
                return true;
            }
            catch (Exception e)
            {
                AddNotification("Erro de Add", e.Message);
                return false;
            }
        }

        public bool Delete(int CidadeId)
        {
            try
            {
                Cidade cidade = unitOfWork.Contexto.Cidades.Where(p => p.CidadeId == CidadeId).FirstOrDefault();
                if (cidade != null)
                {
                    //veirificar pendencias
                    //veiculos
                    int qdeVeiculos = unitOfWork.Contexto.Veiculos.Count(p => p.Endereco.Cidade.CidadeId == cidade.CidadeId);
                    if (qdeVeiculos > 0)
                    {
                        AddNotification("Erro:", "Essa Cidade Possui " + qdeVeiculos + " pendencia(s) em veiculos");
                        return false;
                    }
                    int qdePessoas = unitOfWork.Contexto.Pessoas.Count(p => p.Endereco.Cidade.CidadeId == cidade.CidadeId);
                    if (qdePessoas > 0)
                    {
                        AddNotification("Erro:", "Essa Cidade Possui " + qdePessoas + " pendencia(s) em Pessoas");
                        return false;
                    }
                    unitOfWork.Contexto.Cidades.Remove(cidade);
                    return true;
                }
                else
                {
                    AddNotification("Erro:", "Cidade Inexistente na base de dados");
                    return false;
                }
            }
            catch (Exception e)
            {
                AddNotification("Erro de Delete", e.Message);
                return false;
            }
        }

        public List<Cidade> GetAll()
        {
            try
            {
                return unitOfWork.Contexto.Cidades.ToList();
            }
            catch (Exception e)
            {
                AddNotification("Erro de GetAll", e.Message);
                return null;
            }
        }

        public Cidade GetOne(Expression<Func<Cidade, bool>> condition)
        {
            try
            {
                return unitOfWork.Contexto.Cidades.Where(condition).FirstOrDefault();
            }
            catch (Exception e)
            {
                AddNotification("Erro de GetOne", e.Message);
                return null;
            }
        }

        public List<Cidade> Get(Expression <Func<Cidade, bool>> condition)
        {
            try
            {
                return (unitOfWork.Contexto.Cidades.Where(condition)).ToList();
            }
            catch (Exception e)
            {
                AddNotification("Erro de Get", e.Message);
                return null;
            }
        }


        public void Save()
        {
            unitOfWork.Save();
        }

        public bool Update(Cidade cidade)
        {
            try
            {
                Cidade cidadeAux = GetOne(p => p.Nome == cidade.Nome && p.Uf == cidade.Uf);

                if (cidadeAux != null) // existe uma cidade com este dados
                {
                    // so posso salvar o update se os id forem iguais
                    if (cidadeAux.CidadeId == cidade.CidadeId)
                    {
                        unitOfWork.Contexto.Cidades.Update(cidade);
                        return true;
                    }
                    else
                       AddNotification("Erro de Update", "Já existe um cadastro com este dados, \nnão pode haver duplicidade");
                }
                else // se nao existe uma cidade com este dados entao eu posso salvar
                {
                    unitOfWork.Contexto.Cidades.Update(cidade);
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

        public bool IsExist(Expression<Func<Cidade, bool>> condition)
        {
            if (unitOfWork.Contexto.Cidades.Where(condition).FirstOrDefault() != null)
                return true;
            else return false;
        }
    }
}
