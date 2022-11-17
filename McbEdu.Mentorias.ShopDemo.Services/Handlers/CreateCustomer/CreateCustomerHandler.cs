using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Infrascructure.Repositories.Extensions;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Handlers;
using McbEdu.Mentorias.ShopDemo.Domain.Models.DTOs;

namespace McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer;

public class CreateCustomerHandler : HandlerBase<CreateCustomerResponse, CreateCustomerRequest>
{
    private readonly IExtendsRepository<Customer> _customerExtendsRepository;

    public CreateCustomerHandler(IExtendsRepository<Customer> customerExtendsRepository)
    {
        _customerExtendsRepository = customerExtendsRepository;
    }

    public override Task<CreateCustomerResponse> Handle(in CreateCustomerRequest request)
    {
        throw new NotImplementedException();
    }
}
