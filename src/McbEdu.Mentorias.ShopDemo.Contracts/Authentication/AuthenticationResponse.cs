namespace McbEdu.Mentorias.ShopDemo.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string FirstName,
    string LastName,
    DateTime BirthDate,
    string Email,
    string Token);
