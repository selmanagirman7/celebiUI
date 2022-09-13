using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add(T entity)
        {
            using (var context = new Context())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new Context())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context=new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new Context())
            {
                return filter == null
                    ? context.Set<T>().ToList()
                    : context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (var context = new Context())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
    
    
}