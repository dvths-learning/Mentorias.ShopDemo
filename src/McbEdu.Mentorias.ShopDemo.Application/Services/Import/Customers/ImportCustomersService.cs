namespace McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers;

public class ImportCustomerService : IImportCustomerService
{
    public ImportCustomerResult ImportNewCustomer(string firstName, string lastName, string email, string birthDate)
    {
        return new ImportCustomerResult(Guid.NewGuid(), firstName, lastName, email, birthDate);
    }
}