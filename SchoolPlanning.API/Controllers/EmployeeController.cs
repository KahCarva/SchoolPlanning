using Microsoft.AspNetCore.Mvc;
using SchoolPlanning.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPlanning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        [HttpGet]
        public EmployeeController(IEmployeeService employeeService)
        {
           _employeeService = employeeService;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IEnumerable<Employee>Get()
        {
            return _employeeService.GetAll();
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
