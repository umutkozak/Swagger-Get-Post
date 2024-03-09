using AutoMapper;
using Swagger.DTO_s.EmployeeDtos;
using Swagger.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swager.Services.AutoMapper.Employees
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee,EmployeeDTO>().ReverseMap();
            CreateMap<Employee,EmployeeAddDTO>().ReverseMap();
        }
    }
}
