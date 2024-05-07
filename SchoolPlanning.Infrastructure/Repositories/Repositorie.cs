using Microsoft.EntityFrameworkCore;
using SchoolPlanning.Domain.Entities;
using SchoolPlanning.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Infrastructure.Repositories
{
    public class Repositorie<T> : IDisposable, IRepositorie<T> where T : BaseEntity
    {
        protected readonly SchoolPlanningContext contexto;

        public Repositorie(SchoolPlanningContext contexto)
        {
            this.contexto = contexto;
        }

        public virtual async Task Add(T item)
        {
            await contexto.Set<T>().AddAsync(item);
            await contexto.SaveChangesAsync();
        }

        public virtual async Task Remove(T item)
        {
            contexto.Set<T>().Remove(item);
            await contexto.SaveChangesAsync();
        }

        public virtual async Task Edit(T item)
        {
            contexto.Entry(item).State = EntityState.Modified;
            await contexto.SaveChangesAsync();
        }

        public virtual async Task<T> GetById(object id)
        {
            return await contexto.Set<T>().FindAsync(id);
        }


        public virtual IQueryable<T> GetAll()
        {
            return contexto.Set<T>();
        }


        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
