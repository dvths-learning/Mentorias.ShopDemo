using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Handlers;
using McbEdu.Mentorias.ShopDemo.Domain.Models.ENUMs;

namespace McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer;

public class CreateCustomerRequest : RequestBase
{
    public CreateCustomerRequest(DateTime requestedOn, TypeVerbRequest typeVerbRequest) : base(requestedOn, typeVerbRequest)
    {

    }
}
