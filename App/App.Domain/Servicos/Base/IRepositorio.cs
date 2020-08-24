using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.Domain.Servicos.Base
{
    public interface IRepositorio<T> where T: class
    {
        bool Add(T T);
        bool Update(T cidade);
        bool Delete(int TId);
        void Save();
        List<T> GetAll();
        List<T> Get(Expression <Func<T, bool>> condition);
        T GetOne(Expression <Func<T, bool>> condition);
        bool IsExist(Expression <Func<T, bool>> condition);
    }
}
