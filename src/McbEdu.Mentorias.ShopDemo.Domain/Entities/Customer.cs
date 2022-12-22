namespace McbEdu.Mentorias.ShopDemo.Domain.Entities;

public class Customer
{
    public Guid Id { get; set; }  = Guid.NewGuid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string BirthDate { get; set; } = null!;
}