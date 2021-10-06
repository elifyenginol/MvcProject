﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;
        public void Add(Category category)
        {
            _object.Add(category);
            c.SaveChanges();
        }

        public void Delete(Category category)
        {
            _object.Remove(category);
            c.SaveChanges();
        }

        public List<Category> Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _object.ToList();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
