using App.Infra.Persistencia.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infra
{
    public class UnitOfWork : IUnitOfWork
    {
        public EfContexto Contexto { get; private set; }

        public UnitOfWork()
        {
            Contexto = new EfContexto();
        }
        public void Save()
        {
            Contexto.SaveChanges();
        }
    }
}
