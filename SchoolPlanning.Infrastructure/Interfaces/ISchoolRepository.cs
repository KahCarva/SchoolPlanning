﻿using SchoolPlanning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Infrastructure.Interfaces
{
    public interface ISchoolRepository
    {
        Task Add(School school);

        IEnumerable<School> GetAll();

        Task<School> GetById(int id);
        
        Task UpDate(School school);

        Task DeleteById(int id);
    }
}
