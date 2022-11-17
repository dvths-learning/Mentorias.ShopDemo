using McbEdu.Mentorias.ShopDemo.Domain.Models.ENUMs;

namespace McbEdu.Mentorias.ShopDemo.Domain.Models.Entities;

public class CustomerStandard : CustomerBase
{
    public CustomerStandard(Guid identifier, string name, string surname, string email, DateTime birthday) 
        : base(identifier, name, surname, email, birthday, TypeCustomer.Standard)
    {

    }
}
