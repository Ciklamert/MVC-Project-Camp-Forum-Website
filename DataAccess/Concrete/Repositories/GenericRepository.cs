﻿using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class,IEntity,new()
    {
        Context c = new Context();
        DbSet<T> _object;
        public GenericRepository() // generic item'a bir değer atayacaz
        {
            _object = c.Set<T>(); // context'teki tipe eşittir.
        }
        public void Delete(T item)
        {
            _object.Remove(item);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T item)
        {
            _object.Add(item);
            c.SaveChanges();
        }

        

        public List<T> List(Expression<Func<T, bool>> filter = null)
        {
              return filter == null ? _object.ToList() : _object.Where(filter).ToList();
        }

        public void Update(T item)
        {
            c.SaveChanges();
        }
        
    }
}
