namespace McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers;

public interface IImportCustomerService
{
    ImportCustomerResult ImportNewCustomer(string firstName, string lastName, string email, string birthDate);
}