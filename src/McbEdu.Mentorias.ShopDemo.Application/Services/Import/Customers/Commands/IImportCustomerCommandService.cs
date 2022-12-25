using ErrorOr;

using McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers.Common;

namespace McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers.Commands;

public interface IImportCustomerCommandService
{
    ErrorOr<ImportCustomerResult> ImportNewCustomer(
        string firstName,
        string lastName,
        string email,
        string birthDate);
}