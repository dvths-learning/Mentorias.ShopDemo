using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Infrascructure.Repositories;
using McbEdu.Mentorias.ShopDemo.Domain.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace McbEdu.Mentorias.ShopDemo.Infrascructure.Data.Repositories;

public class CustomerRepository : IBaseRepository<Customer>
{
    protected readonly DataContext _dataContext;

    public CustomerRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task AddAsync(Customer entity)
    {
        await _dataContext.Customers.AddAsync(entity);
        await _dataContext.SaveChangesAsync();
    }

    public async Task AddRangeAsync(List<Customer> entity)
    {
        await _dataContext.Customers.AddRangeAsync(entity);
        await _dataContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Customer entity)
    {
        if (await _dataContext.Customers.CountAsync() < 1) return;

        _dataContext.Customers.Remove(entity);
        await _dataContext.SaveChangesAsync();
    }

    public async Task<List<Customer>> GetAllAsync()
    {
        if (await _dataContext.Customers.CountAsync() < 1) return new List<Customer>();

        return await _dataContext.Customers.ToListAsync();
    }

    public async Task<Customer?> GetAsync(Guid identifier)
    {
        if (await _dataContext.Customers.CountAsync() < 1) return null;

        return await _dataContext.Customers.Where(p => p.Identifier == identifier).FirstAsync();
    }

    public async Task UpdateAsync(Customer entity)
    {
        if (await _dataContext.Customers.CountAsync() < 1) return;

        _dataContext.Customers.Update(entity);
        await _dataContext.SaveChangesAsync();
    }
}
