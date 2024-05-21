using SchoolPlanning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task Add(Employee employee);

        IEnumerable<Employee> GetAll();

        Task<Employee> GetById(int id);

        Task UpDate(Employee employee);

        Task DeleteById(int id);
    }
}
