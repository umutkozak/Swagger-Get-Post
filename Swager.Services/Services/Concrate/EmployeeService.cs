using Swager.Services.Services.Abstraction;
using Swagger.Core.Abstraction;
using Swagger.DTO_s.EmployeeDtos;
using Swagger.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swager.Services.Services.Concrate
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Swagger.Entity.Employee> rp;

        public EmployeeService(IRepository<Swagger.Entity.Employee> rp)
        {
            this.rp=rp;
        }
        public void Add(Employee item)
        {
            rp.Add(item);
        }

        public List<Employee> GetAll()
        {
             return rp.GetAll();
        }
    }
}
