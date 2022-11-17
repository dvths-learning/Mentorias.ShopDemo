namespace McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer.Inputs;

public class CreateCustomerInputModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public DateOnly Birthday { get; set; }

    public CreateCustomerInputModel()
    {
        Name = Surname = Email = string.Empty;
    }
}
