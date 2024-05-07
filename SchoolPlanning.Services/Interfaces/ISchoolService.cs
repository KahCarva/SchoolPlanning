using SchoolPlanning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Services.Interfaces
{
    public interface ISchoolService
    {
        Task Add(School school);

        IEnumerable<School> GetAll();

    }
}
