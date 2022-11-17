using FluentValidation;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Infrascructure.Mappings;
using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Adapters;
using McbEdu.Mentorias.ShopDemo.Domain.Models.DTOs;
using McbEdu.Mentorias.ShopDemo.Domain.Models.Entities;
using McbEdu.Mentorias.ShopDemo.Domain.Models.Entities.Notification.Consumer;
using McbEdu.Mentorias.ShopDemo.Domain.Models.Entities.Notification.Content;
using McbEdu.Mentorias.ShopDemo.Domain.Models.Entities.Notification.Publisher;
using McbEdu.Mentorias.ShopDemo.Domain.Models.Validators;
using McbEdu.Mentorias.ShopDemo.Infrascructure.Data;
using McbEdu.Mentorias.ShopDemo.Infrascructure.Data.Mappings;
using McbEdu.Mentorias.ShopDemo.Services.Adapters;
using McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer.Inputs;

namespace McbEdu.Mentorias.ShopDemo.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<DataContext>();

        builder.Services.AddTransient<NotifiablePublisherStandard>();
        builder.Services.AddTransient<NotifiableConsumerStandard>();
        builder.Services.AddTransient<IAdapter<CustomerStandard, CreateCustomerInputModel>, AdapterCreateCustomerInputModelToCustomerStandard>();

        builder.Services.AddScoped<NotifiableStandard>();
        builder.Services.AddScoped<AbstractValidator<CustomerBase>, CustomerValidator>();
        builder.Services.AddScoped<DataContext>();

        builder.Services.AddSingleton<IBaseMapping<Customer>, CustomerBaseMapping>();

        var app = builder.Build();
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}