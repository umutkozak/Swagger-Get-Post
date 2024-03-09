using Swagger.DTO_s.EmployeeDtos;
using Swagger.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swager.Services.Services.Abstraction
{
    public interface IEmployeeService
    {
        public void Add(Employee dto);
        public List<Employee> GetAll();
    }
}
