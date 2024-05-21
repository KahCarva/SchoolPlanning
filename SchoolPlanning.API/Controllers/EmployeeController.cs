using Microsoft.AspNetCore.Mvc;
using SchoolPlanning.Domain.Entities;
using SchoolPlanning.Services;
using SchoolPlanning.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPlanning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
           _employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Employee> Get(int id)
        {
            return await _employeeService.GetById(id);
        }

        [HttpPost]
        public async Task Post([FromBody] Employee employee)
        {
            await _employeeService.Add(employee);
        }

        [HttpPut("{id}")]
        public async Task Put([FromBody] Employee employee, int id)
        {
            await _employeeService.UpDate(employee);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _employeeService.DeleteById(id);
        }
    }
}
