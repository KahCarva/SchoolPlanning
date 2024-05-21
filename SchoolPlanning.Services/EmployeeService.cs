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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository; ;
        }

        public async Task Add(Employee employee)
        {

            await _employeeRepository.Add(employee);
        }



        public async Task DeleteById(int id)
        {
            await _employeeRepository.DeleteById(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return (IEnumerable<Employee>)_employeeRepository.GetAll();
        }

        public async Task <Employee> GetById(int id)
        {
            return await _employeeRepository.GetById(id);
        }

        public async Task UpDate(Employee employee)
        {
            await _employeeRepository.UpDate(employee);
        }
    }
}
