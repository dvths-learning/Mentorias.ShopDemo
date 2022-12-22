using McbEdu.Mentorias.ShopDemo.Application.Common.Interfaces.Persistence;
using McbEdu.Mentorias.ShopDemo.Domain.Entities;

namespace McbEdu.Mentorias.ShopDemo.Infrastructure.Persistence;

public class CustomerRepository : ICustomerRepository
{
    private static readonly List<Customer> _customers = new();

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public Customer? GetCustomerByEmail(string email)
    {
       return _customers.SingleOrDefault(customer => customer.Email == email);
    }
}