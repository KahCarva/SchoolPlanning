namespace SchoolPlanning.Infrastructure.Interfaces
{
    public interface IRepositorie<T> where T : class

    {
        Task  Add(T item);

        Task Remove(T item);

        Task Edit(T item);

        Task<T> GetById(object id);

        IQueryable<T> GetAll();

    }
}
