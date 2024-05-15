using Microsoft.AspNetCore.Mvc;
using SchoolPlanning.Domain.Entities;
using SchoolPlanning.Services;
using SchoolPlanning.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPlanning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {

        private readonly IClassesService _classesService;

        public ClassesController(IClassesService classesService)
        {
            _classesService = classesService;
        }

        [HttpGet]
        public IEnumerable<Classes> Get()
        {
            return _classesService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Classes> Get(int id)
        {
            return await _classesService.GetById(id);
        }

        [HttpPost]
        public async Task Post([FromBody] Classes classes)
        {
            await _classesService.Add(classes);
        }

        [HttpPut("{id}")]
        public async Task Put([FromBody] Classes classes, int id)
        {
            await _classesService.UpDate(classes);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _classesService.DeleteById(id);
        }
    }
}
