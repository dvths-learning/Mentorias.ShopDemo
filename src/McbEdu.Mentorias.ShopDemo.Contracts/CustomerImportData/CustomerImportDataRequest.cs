namespace McbEdu.Mentorias.ShopDemo.Contracts.ImportCustomer;

public record CustomerImportDataRequest(
    string FirstName,
    string LastName,
    string Email,
    string BirthDate);
