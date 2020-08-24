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
    public class RepositorioVeiculo : Notifiable, IRepositorioVeiculo
    {
        private IUnitOfWork unitOfWork;
        public RepositorioVeiculo(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public bool Add(Veiculo Veiculo)
        {
            try
            {
                unitOfWork.Contexto.Veiculos.Add(Veiculo);
                return true;
            }
            catch (Exception e)
            {
                AddNotification("Erro de Add", e.Message);
                return false;
            }
        }

        public bool Delete(int VeiculoId)
        {
            try
            {


                Veiculo veiculo = unitOfWork.Contexto.Veiculos.Where(p => p.VeiculoId == VeiculoId).FirstOrDefault();
                if (veiculo != null)
                {
                    
                    unitOfWork.Contexto.Veiculos.Remove(veiculo);
                    return true;
                }
                else
                {
                    AddNotification("Erro:", "Veiculo Inexistente na base de dados");
                    return false;
                }
            }
            catch (Exception e)
            {
                AddNotification("Erro de Delete", e.Message);
                return false;
            }
        }

        public List<Veiculo> GetAll()
        {
            try
            {
                return unitOfWork.Contexto.Veiculos.Include(p => p.Placa).Include(pe => pe.Pessoa).ToList();
            }
            catch (Exception e)
            {
                AddNotification("Erro de GetAll", e.Message);
                return null;
            }
        }

        public Veiculo GetOne(Expression<Func<Veiculo, bool>> condition)
        {
            try
            {
                return unitOfWork.Contexto.Veiculos.Include(p => p.Endereco.Cidade).Include(pe => pe.Pessoa).Include(m => m.Marca).Where(condition).FirstOrDefault();
            }
            catch (Exception e)
            {
                AddNotification("Erro de GetOne", e.Message);
                return null;
            }
        }

        public List<Veiculo> Get(Expression<Func<Veiculo, bool>> condition)
        {
            try
            {
                return unitOfWork.Contexto.Veiculos.Where(condition).ToList();
            }
            catch (Exception e)
            {
                AddNotification("Erro de GetWith", e.Message);
                return null;
            }
        }

        public void Save()
        {
            try
            {
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                AddNotification("Erro: ", e.Message);
            }
        }

        public bool Update(Veiculo veiculo)
        {
            //try
            //{
            //    unitOfWork.Contexto.Veiculos.Update(veiculo);
            //    return true;
            //}
            //catch (Exception e)
            //{
            //    AddNotification("Erro de Update", e.Message);
            //    return false;
            //}

            try
            {

                Veiculo veiculoAux = GetOne(p => p.Placa.Valor == veiculo.Placa.Valor && p.Ativo == true);

                if (veiculoAux != null) // existe um com este dados
                {
                    // so posso salvar o update se os id forem iguais
                    if (veiculoAux.VeiculoId == veiculo.VeiculoId)
                    {
                        unitOfWork.Contexto.Veiculos.Update(veiculo);
                        return true;
                    }
                    else
                        AddNotification("Erro ao Alterar", "Já existe cadastro desta placa ATIVO no sistema, erro de duplicidade");
                }
                else
                {
                    unitOfWork.Contexto.Veiculos.Update(veiculo);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                AddNotification("Erro de Update", e.Message);
                return false;
            }
        }

        public bool IsExist(Expression<Func<Veiculo, bool>> condition)
        {
            if (unitOfWork.Contexto.Veiculos.Where(condition).FirstOrDefault() != null)
                return true;
            else return false;
        }
    }
}
