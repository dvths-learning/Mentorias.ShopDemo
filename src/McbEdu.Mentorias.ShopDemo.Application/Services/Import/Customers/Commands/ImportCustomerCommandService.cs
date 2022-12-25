using ErrorOr;

using McbEdu.Mentorias.ShopDemo.Application.Common.Interfaces.Persistence;
using McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers.Common;
using McbEdu.Mentorias.ShopDemo.Domain.Common.Errors;
using McbEdu.Mentorias.ShopDemo.Domain.Entities;

namespace McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers.Commands;

public class ImportCustomerCommandService : IImportCustomerCommandService
{
    private readonly ICustomerRepository _customerRepository;

    public ImportCustomerCommandService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public ErrorOr<ImportCustomerResult> ImportNewCustomer(
        string firstName,
        string lastName,
        string email,
        string birthDate)
    {
        // 1. checar se o cliente não existe no banco
        if (_customerRepository.GetCustomerByEmail(email) is not null)
        {
            return Errors.Customer.EmailAlreadyExists;
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