using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class Service<T> : IService<T> where T : class
    {
        public IUnitOfWork UnitOfWork { get; private set; }
        readonly IGenericRepository<T> repository;
        public Service(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            repository = unitOfWork.Repository<T>();
        }
        public T GetById(params object[] keyValues)
        {
            return repository.GetById(keyValues);
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return repository.Get(where);
        }
        public IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }
        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return repository.GetMany(where);
        }
        public void Add(T entity)
        {
            repository.Add(entity);
        }
        public void Update(T entity)
        {
            repository.Update(entity);
        }
        public void Delete(T entity)
        {
            repository.Delete(entity);
        }
        public void Delete(Expression<Func<T, bool>> where)
        {
            repository.Delete(where);
        }
    }
}
