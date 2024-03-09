using Swagger.Core.Abstraction;
using Swagger.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Core.Concrate
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly AppDbContext context;

        public Repository(AppDbContext context)
        {
            this.context=context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
