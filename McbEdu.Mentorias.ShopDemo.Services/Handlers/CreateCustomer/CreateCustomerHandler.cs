using FluentValidation;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Infrascructure.Repositories.Extensions;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Handlers;
using McbEdu.Mentorias.ShopDemo.Domain.Models.DTOs;

namespace McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer;

public class CreateCustomerHandler : HandlerBase<CreateCustomerResponse, CreateCustomerRequest>
{
    private readonly IExtendsRepository<Customer> _customerExtendsRepository;
    private readonly AbstractValidator<Customer> _customerValidator;

    public CreateCustomerHandler(IExtendsRepository<Customer> customerExtendsRepository, AbstractValidator<Customer> customerValidator)
    {
        _customerExtendsRepository = customerExtendsRepository;
        _customerValidator = customerValidator;
    }

    public override Task<CreateCustomerResponse> Handle(in CreateCustomerRequest request)
    {
        throw new NotImplementedException();
    }
}
