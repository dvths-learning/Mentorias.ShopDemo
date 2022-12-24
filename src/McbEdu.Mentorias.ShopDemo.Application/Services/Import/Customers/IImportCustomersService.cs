using ErrorOr;
namespace McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers;

public interface IImportCustomerService
{
    ErrorOr<ImportCustomerResult> ImportNewCustomer(
        string firstName,
        string lastName,
        string email,
        string birthDate);
}