namespace SchoolPlanning.Infrastructure.Interfaces
{
    public interface IRepositorie<T> where T : class

    {
        void Add(T item);

        void Remove(T item);

        void Edit(T item);

        T GetById(object id);

        IQueryable<T> GetAll();

    }
}
