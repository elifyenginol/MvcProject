using DataAccess.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Add(T entity)
        {
            _object.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _object.Remove(entity);
            context.SaveChanges();
        }

        public List<T> Get(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {

            context.SaveChanges();
        }

        T IRepository<T>.Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }
    }
}
