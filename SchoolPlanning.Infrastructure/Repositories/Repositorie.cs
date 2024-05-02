using Microsoft.EntityFrameworkCore;
using SchoolPlanning.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlanning.Infrastructure.Repositories
{
    public class Repositorie<T> : IDisposable, IRepositorie<T> where T : class
    {
        protected readonly SchoolPlanningContext contexto;

        public Repositorie(SchoolPlanningContext contexto)
        {
            this.contexto = contexto;
        }

        public virtual void Add(T item)
        {
            contexto.Set<T>().Add(item);
            contexto.SaveChanges();
        }

        public virtual void Remove(T item)
        {
            contexto.Set<T>().Remove(item);
            contexto.SaveChanges();
        }

        public virtual void Edit(T item)
        {
            contexto.Entry(item).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public virtual T GetById(object id)
        {
            return contexto.Set<T>().Find(id);
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
