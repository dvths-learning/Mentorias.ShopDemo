using ErrorOr;

using McbEdu.Mentorias.ShopDemo.Application.Import.Common;

using MediatR;

namespace McbEdu.Mentorias.ShopDemo.Application.Import.Commands.ImportOneCustomerCommand;

// encapsula os dados necessário para executar o comando
public record ImportOneCustomerCommand(
    string FirstName,
    string LastName,
    string Email,
    string BirthDate) : IRequest<ErrorOr<ImportCustomerResult>>;