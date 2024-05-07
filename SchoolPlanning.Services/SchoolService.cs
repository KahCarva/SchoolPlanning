using SchoolPlanning.Domain.Entities;
using SchoolPlanning.Infrastructure;
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
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _schoolRepository;

        public SchoolService(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;   
        }

        public async Task Add(School school)
        {
            await _schoolRepository.Add(school);
        }

        public async Task DeleteById(int id)
        {
            await _schoolRepository.DeleteById(id);
        }

        public IEnumerable<School> GetAll()
        {
            return _schoolRepository.GetAll().ToList();
        }

        public async Task<School> GetById(int id)
        {
            return await _schoolRepository.GetById(id);
        }

        public async Task UpDate(School school)
        {
            await _schoolRepository.UpDate(school);
        }
    }
}
