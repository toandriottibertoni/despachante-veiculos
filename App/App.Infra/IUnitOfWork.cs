using App.Infra.Persistencia.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infra
{
    public interface IUnitOfWork
    {
        EfContexto Contexto { get; }
        void Save();
    }
}
