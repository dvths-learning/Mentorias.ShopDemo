namespace McbEdu.Mentorias.ShopDemo.Domain.Contracts.Infrascructure.Repositories;

public interface IBaseRepository<T> where T : class
{
    public Task AddAsync(T entity);
    public Task AddRangeAsync(List<T> entity);
    public Task UpdateAsync(T entity);
    public Task DeleteAsync(T entity);
    public Task<T?> GetAsync(Guid identifier);
    public Task<List<T>> GetAllAsync();
}