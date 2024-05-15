using SchoolPlanning.Domain.Entities;
using SchoolPlanning.Infrastructure.Interfaces;
using SchoolPlanning.Infrastructure.Repositories;
using SchoolPlanning.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Services
{
    public class ClassesService : IClassesService
    {
        private readonly IClassesRepository _classesRepository;

        public ClassesService(IClassesRepository classesRepository)
        {
            _classesRepository = classesRepository;
        }

        public async Task Add(Classes classes)
        {
            await _classesRepository.Add(classes);
        }

        public async Task DeleteById(int id)
        {
            await _classesRepository.DeleteById(id);
        }

        public IEnumerable<Classes> GetAll()
        {
            return _classesRepository.GetAll();
        }

        public async Task<Classes> GetById(int id)
        {
            return await _classesRepository.GetById(id);
        }

        public async Task UpDate(Classes classes)
        {
            await _classesRepository.UpDate(classes);
        }
    }
}
