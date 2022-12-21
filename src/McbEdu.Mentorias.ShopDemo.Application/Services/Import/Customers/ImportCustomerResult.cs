namespace McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers;

public record ImportCustomerResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string BirthDate);