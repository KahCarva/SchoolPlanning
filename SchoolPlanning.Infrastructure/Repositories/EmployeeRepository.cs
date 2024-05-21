﻿using SchoolPlanning.Domain.Entities;
using SchoolPlanning.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Infrastructure.Repositories
{
    public class EmployeeRepository : Repositorie<Employee>, IEmployeeRepository
    {
        private readonly SchoolPlanningContext _context;
        public EmployeeRepository(SchoolPlanningContext contexto) : base(contexto)
        {
            _context = contexto;
        }

        public async Task Add(Employee employee)
        {
            await base.Add(employee);
        }

        public Task Add(Classes classes)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteById(int id)
        {
            var employee = await base.GetById(id);
            await base.Remove(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return base.GetAll().ToList();
        }

        public async Task<Employee> GetById(int id)
        {
            return await base.GetById(id);
        }

        public async Task UpDate(Employee employee)
        {
            await base.Edit(employee);
        }

        public Task UpDate(Classes classes)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Classes> IEmployeeRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<Classes> IEmployeeRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
