using App.Domain.Entidades;
using App.Domain.Servicos;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace App.Infra.Repositorios
{
    public class RepositorioMarca : Notifiable, IRepositorioMarca
    {
        private IUnitOfWork unitOfWork;
        public RepositorioMarca(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public bool Add(Marca Marca)
        {
            try
            {
                unitOfWork.Contexto.Marcas.Add(Marca);
                return true;
            }
            catch (Exception e)
            {
                AddNotification("Erro de Add", e.Message);
                return false;
            }
        }

        public bool Delete(int MarcaId)
        {
            try
            {
                Marca marca = unitOfWork.Contexto.Marcas.Where(p => p.MarcaId == MarcaId).FirstOrDefault();
                if (marca != null)
                {
                    //veirificar pendencias
                    //veiculos
                    int qde = unitOfWork.Contexto.Veiculos.Count(p => p.Marca.MarcaId == marca.MarcaId);
                    if (qde > 0)
                    {
                        AddNotification("Erro:", "Essa Marca Possui " + qde + " pendencia(s) em veiculos");
                        return false;
                    }
                    unitOfWork.Contexto.Marcas.Remove(marca);
                    return true;
                }
                else
                {
                    AddNotification("Erro:", "Marca Inexistente na base de dados");
                    return false;
                }
            }
            catch (Exception e)
            {
                AddNotification("Erro de Delete", e.Message);
                return false;
            }
        }

        public List<Marca> GetAll()
        {
            try
            {
                return unitOfWork.Contexto.Marcas.ToList();
            }
            catch (Exception e)
            {
                AddNotification("Erro de GetAll", e.Message);
                return null;
            }
        }

        public Marca GetOne(Expression <Func<Marca, bool>> condition)
        {
            try
            {
                return unitOfWork.Contexto.Marcas.Where(condition).FirstOrDefault();
            }
            catch (Exception e)
            {
                AddNotification("Erro de GetOne", e.Message);
                return null;
            }
        }

        public List<Marca> Get(Expression <Func<Marca, bool>> condition)
        {
            try
            {
                return unitOfWork.Contexto.Marcas.Where(condition).ToList();
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

        public bool Update(Marca marca)
        {
            //try
            //{
            //    unitOfWork.Contexto.Marcas.Update(marca);
            //    return true;
            //}
            //catch (Exception e)
            //{
            //    AddNotification("Erro de Update", e.Message);
            //    return false;
            //}
            try
            {
                Marca MarcaAux = GetOne(p => p.Nome == marca.Nome);

                if (MarcaAux != null) // existe uma cidade com este dados
                {
                    // so posso salvar o update se os id forem iguais
                    if (MarcaAux.MarcaId == marca.MarcaId)
                    {
                        unitOfWork.Contexto.Marcas.Update(marca);
                        return true;
                    }
                    else
                        AddNotification("Erro de Update", "Já existe um cadastro com este dados, não pode haver duplicidade");
                }
                else // se nao existe uma cidade com este dados entao eu posso salvar
                {
                    unitOfWork.Contexto.Marcas.Update(marca);
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

        public bool IsExist(Expression <Func<Marca, bool>> condition)
        {
            if (unitOfWork.Contexto.Marcas.Where(condition).FirstOrDefault() != null)
                return true;
            else return false;
        }
    }
}
