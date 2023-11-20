using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        Context dbContext = new Context();
        bool disposed;

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public IGenericRepository<T> Repository<T>() where T : class
        {
            return new GenericRepository<T>(dbContext.Set<T>()); ;
        }

            public void Dispose(bool disposing)
            {
                if (disposed)
                { return; }
                if (disposing)
                {
                    dbContext?.Dispose();
                }

                disposed = true;
            }
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

         ~UnitOfWork()
             {
                  Dispose(false);
             }

    }

    }

