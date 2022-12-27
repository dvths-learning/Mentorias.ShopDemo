using ErrorOr;

using McbEdu.Mentorias.ShopDemo.Application.Common.Interfaces.Persistence;
using McbEdu.Mentorias.ShopDemo.Domain.Entities;
using McbEdu.Mentorias.ShopDemo.Domain.Common.Errors;

using MediatR;
using McbEdu.Mentorias.ShopDemo.Application.Import.Common;

namespace McbEdu.Mentorias.ShopDemo.Application.Import.Commands.ImportOneCustomerCommand;

public class ImportOneCustomerCommandHandler :
    IRequestHandler<ImportOneCustomerCommand, ErrorOr<ImportCustomerResult>>
{
    private readonly ICustomerRepository _customerRepository;
    public ImportOneCustomerCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<ErrorOr<ImportCustomerResult>> Handle(
        ImportOneCustomerCommand command,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        // 1. checar se o cliente não existe no banco
        if (_customerRepository.GetCustomerByEmail(command.Email) is not null)
        {
            return Errors.Customer.EmailAlreadyExists;
        }

        // 2. Criar um novo cliente 
        var newCustomer = new Customer
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            BirthDate = command.BirthDate
        };

        // Persistir no bd
        _customerRepository.AddCustomer(newCustomer);

        // Retornar novo client
        return new ImportCustomerResult(newCustomer);
    }
}