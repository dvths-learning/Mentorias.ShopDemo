using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Handlers;

namespace McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer;

public class CreateCustomerHandler : HandlerBase<CreateCustomerResponse, CreateCustomerRequest>
{


    public CreateCustomerHandler()
    {

    }

    public override Task<CreateCustomerResponse> Handle(in CreateCustomerRequest request)
    {
        throw new NotImplementedException();
    }
}
