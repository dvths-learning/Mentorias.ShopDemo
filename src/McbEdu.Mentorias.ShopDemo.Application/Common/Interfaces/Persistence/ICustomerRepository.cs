using McbEdu.Mentorias.ShopDemo.Domain.Entities;

namespace McbEdu.Mentorias.ShopDemo.Application.Common.Interfaces.Persistence;

public interface ICustomerRepository
{
    Customer? GetCustomerByEmail(string email);
    void AddCustomer(Customer customer);
}