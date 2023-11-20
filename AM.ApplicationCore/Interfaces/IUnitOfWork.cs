namespace AM.ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> Repository<T>() where T : class;
        void Commit();
    }
}
