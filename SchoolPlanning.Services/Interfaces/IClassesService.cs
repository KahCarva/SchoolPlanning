using SchoolPlanning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Services.Interfaces
{
    public interface IClassesService
    {
        Task Add(Classes classes);

        IEnumerable<Classes> GetAll();

        Task<Classes> GetById(int id);

        Task UpDate(Classes classes);

        Task DeleteById(int id);
    }
}
