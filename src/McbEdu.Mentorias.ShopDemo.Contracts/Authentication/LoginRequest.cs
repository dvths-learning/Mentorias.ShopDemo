namespace McbEdu.Mentorias.ShopDemo.Contracts.Authentication;

public record LoginRequest(
    string Email,
    string Password
);
