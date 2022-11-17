using FluentValidation;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Infrascructure.Repositories.Extensions;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Adapters;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Handlers;
using McbEdu.Mentorias.ShopDemo.Domain.Models.DTOs;
using McbEdu.Mentorias.ShopDemo.Domain.Models.Entities;
using McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer.Inputs;

namespace McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer;

public class CreateCustomerHandler : HandlerBase<CreateCustomerResponse, CreateCustomerRequest>
{
    private readonly IExtendsRepository<Customer> _customerExtendsRepository;
    private readonly AbstractValidator<Customer> _customerValidator;
    private readonly IAdapter<CustomerStandard, CreateCustomerInputModel> _adapterCustomer;

    public CreateCustomerHandler(IExtendsRepository<Customer> customerExtendsRepository, AbstractValidator<Customer> customerValidator,
        IAdapter<CustomerStandard, CreateCustomerInputModel> adapter)
    {
        _customerExtendsRepository = customerExtendsRepository;
        _customerValidator = customerValidator;
        _adapterCustomer = adapter;
    }

    public override Task<CreateCustomerResponse> Handle(in CreateCustomerRequest request)
    {
        throw new NotImplementedException();
    }
}
