using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);  
        void Delete(T entity);
        List<T> GetAll();
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        T GetById(int id);
    }
}
