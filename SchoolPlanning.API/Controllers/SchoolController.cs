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
        public async Task<School> Get(int id)
        {
            return await _schoolService.GetById(id);
        }

        // POST api/<SchoolController>
        [HttpPost]
        public async Task Post([FromBody] School school)
        {
           await _schoolService.Add(school);
        }

        // PUT api/<SchoolController>/5
        [HttpPut("{id}")]
        public async Task  Put([FromBody] School school, int id)
        {
            await _schoolService.UpDate(school);
        }

        // DELETE api/<SchoolController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _schoolService.DeleteById(id);
        }
    }
}
