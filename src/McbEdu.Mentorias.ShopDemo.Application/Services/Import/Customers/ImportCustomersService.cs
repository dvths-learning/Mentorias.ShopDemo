using McbEdu.Mentorias.ShopDemo.Application.Common.Interfaces.Persistence;
using McbEdu.Mentorias.ShopDemo.Domain.Entities;

namespace McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers;

public class ImportCustomerService : IImportCustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public ImportCustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public ImportCustomerResult ImportNewCustomer(
        string firstName,
        string lastName,
        string email,
        string birthDate)
    {
        // 1. checar se o cliente não existe no banco
        if (_customerRepository.GetCustomerByEmail(email) is not null)
        {
            throw new Exception("Customer with given email already exists.");
        }

        // 2. Criar um novo cliente 
        var newCustomer = new Customer
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            BirthDate = birthDate
        };

        // Persistir no bd
        _customerRepository.AddCustomer(newCustomer);

        // Retornar novo client
        return new ImportCustomerResult(newCustomer);
    }
}