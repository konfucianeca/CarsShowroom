namespace CarsShowroom.Infrastructure.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> AllAsync<T>() where T : class;
        IQueryable<T> AllReadOnlyAsync<T>() where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task<int> SaveChangesAsync();
    }
}
