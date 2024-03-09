using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Core.Abstraction
{
    public interface IRepository<T>where T : class, new()
    {
        void Add(T entity);
        List<T> GetAll();
    }
}
