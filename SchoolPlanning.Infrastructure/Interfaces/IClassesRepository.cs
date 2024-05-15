using SchoolPlanning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Infrastructure.Interfaces
{
    public interface IClassesRepository

    {
        Task Add(Classes classes);

        Task<Classes> GetById(int id);

        Task UpDate(Classes classes);

        Task DeleteById(int id);

        IEnumerable<Classes> GetAll();

    }
}

