using FluentValidation;
using FluentValidation.Results;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Infrascructure.Repositories.Extensions;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Adapters;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Handlers;
using McbEdu.Mentorias.ShopDemo.Domain.Models.DTOs;
using McbEdu.Mentorias.ShopDemo.Domain.Models.Entities;
using McbEdu.Mentorias.ShopDemo.Domain.Models.Entities.Notification.Publisher;
using McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer.Inputs;

namespace McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer;

public class CreateCustomerHandler : HandlerBase<CreateCustomerResponse, CreateCustomerRequest>
{
    private readonly IExtendsRepository<Customer> _customerExtendsRepository;
    private readonly AbstractValidator<CustomerBase> _customerValidator;
    private readonly IAdapter<CustomerStandard, CreateCustomerInputModel> _adapterCustomer;
    private readonly NotifiablePublisherStandard _notifiablePublisherStandard;

    public CreateCustomerHandler(IExtendsRepository<Customer> customerExtendsRepository, AbstractValidator<CustomerBase> customerValidator,
        IAdapter<CustomerStandard, CreateCustomerInputModel> adapter, NotifiablePublisherStandard notifiablePublisherStandard)
    {
        _customerExtendsRepository = customerExtendsRepository;
        _customerValidator = customerValidator;
        _adapterCustomer = adapter;
        _notifiablePublisherStandard = notifiablePublisherStandard;
    }

    public override async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request)
    {
        var customer = _adapterCustomer.Adapt(request.InputModel);

        var validation = _customerValidator.Validate(customer);

        if (await _customerExtendsRepository.VerifyEntityExistsAsync(customer.Email) == true)
        {

        }
    }
}
