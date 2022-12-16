namespace McbEdu.Mentorias.ShopDemo.Contracts.Authentication;

public record RegisterRequest(
    string FirstName,
    string LastName,
    DateTime BirthDate,
    string Email,
    string Password);
