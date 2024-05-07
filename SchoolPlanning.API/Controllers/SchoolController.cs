using Microsoft.AspNetCore.Mvc;
using SchoolPlanning.Domain.Entities;
using SchoolPlanning.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPlanning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }


        // GET: api/<SchoolController>
        [HttpGet]
        public IEnumerable<School> Get()
        {
            return _schoolService.GetAll();
        }

        // GET api/<SchoolController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SchoolController>
        [HttpPost]
        public void Post([FromBody] School school)
        {
            _schoolService.Add(school);
        }

        // PUT api/<SchoolController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SchoolController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
