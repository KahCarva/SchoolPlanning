using SchoolPlanning.Domain.Entities;
using SchoolPlanning.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Infrastructure.Repositories
{
    public class SchoolRepository : Repositorie<School>, ISchoolRepository
    {
        private readonly SchoolPlanningContext _context;

        public SchoolRepository(SchoolPlanningContext context) : base(context)
        {
            _context = context;
        }

        public async Task Add(School school)
        {
           await base.Add(school);
        }

        public async Task DeleteById(int id)
        {
            var school = await base.GetById(id);
            await base.Remove(school);
        }

        public IEnumerable<School> GetAll()
        {
            return base.GetAll().ToList();
        }

        public async Task<School> GetById(int id)
        {
            return await base.GetById(id);
        }

        public async Task UpDate(School school)
        {
           await base.Edit(school);
        }
    }
}
