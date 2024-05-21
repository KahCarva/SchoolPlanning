using SchoolPlanning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Infrastructure.Interfaces
{
    public interface IEmployeeRepository
    {
        Task Add(Employee employee);

        Task<Employee> GetById(int id);

        Task UpDate(Employee employee);

        Task DeleteById(int id);

        IEnumerable<Employee> GetAll();
    }
}
