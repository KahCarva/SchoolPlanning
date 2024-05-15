using SchoolPlanning.Domain.Entities;
using SchoolPlanning.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Infrastructure.Repositories
{
    public class ClassesRepository : Repositorie<Classes>, IClassesRepository
    {

        private readonly SchoolPlanningContext _context;

        public ClassesRepository(SchoolPlanningContext context) : base(context)
        {
            _context = context;
        }

        public async Task Add(Classes classes)
        {
           await base.Add(classes); 
        }

        public  async Task DeleteById(int id)
        {
            var classes = await base.GetById(id);
            await base.Remove(classes);
        }

        public async Task<Classes> GetById(int id)
        {
            return await base.GetById(id);
        }

        public async Task UpDate(Classes classes)
        {
            await base.Edit(classes); 
        }

        public IEnumerable<Classes> GetAll()
        {
            return base.GetAll().ToList();
        }
    }
}
