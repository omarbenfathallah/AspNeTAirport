using System.Linq.Expressions;

namespace AM.ApplicationCore.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(params object[] keyValues);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
    }
}
