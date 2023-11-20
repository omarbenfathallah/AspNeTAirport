using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
       // private readonly 
        DbSet<T> dbSet;

        public GenericRepository(DbSet<T> dbSet)
        {
           // _dbSet = dbSet ?? throw new ArgumentNullException(nameof(dbSet));
            this.dbSet = dbSet;
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            var entities = dbSet.Where(where);
            dbSet.RemoveRange(entities);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault();
            
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsEnumerable();
        }

        public T GetById(params object[] keyValues)
        {
            return dbSet.Find(keyValues);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}