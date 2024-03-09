using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swager.Services.Services.Abstraction;
using Swagger.DataAccess.Context;
using Swagger.DTO_s.EmployeeDtos;
using Swagger.Entity;

namespace Swagger.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext db;
        private readonly IMapper mapper;
        private readonly IEmployeeService service;
        
        public EmployeeController(AppDbContext db,IMapper mapper,IEmployeeService service)
        {
            this.db=db;
            this.mapper=mapper; 
            this.service=service;
        }

        

        [HttpGet]
        public List<EmployeeDTO> Get()
        {
            var employees = service.GetAll();
            List<EmployeeDTO> emps=mapper.Map<List<EmployeeDTO>>(employees);
            return emps ;
        }
        [HttpPost("{Add}")]
        public bool Add(EmployeeAddDTO dto)
        {
            var employee=mapper.Map<Employee>(dto);

            service.Add(employee);
            return true;
        }
    }
}
