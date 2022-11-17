using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Handlers;
using McbEdu.Mentorias.ShopDemo.Domain.Models.ENUMs;
using McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer.Inputs;

namespace McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer;

public class CreateCustomerRequest : RequestBase
{
    public CreateCustomerInputModel InputModel { get; }

    public CreateCustomerRequest(DateTime requestedOn, TypeVerbRequest typeVerbRequest, CreateCustomerInputModel inputModel) : base(requestedOn, typeVerbRequest)
    {
        InputModel = inputModel;
    }
}
