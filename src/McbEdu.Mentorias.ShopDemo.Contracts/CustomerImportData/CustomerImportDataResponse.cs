namespace McbEdu.Mentorias.ShopDemo.Contracts.ImportCustomer;

public record CustomerImportDataResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string BirthDate);
