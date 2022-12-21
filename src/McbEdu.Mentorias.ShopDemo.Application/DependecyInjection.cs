using McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers;

using Microsoft.Extensions.DependencyInjection;

namespace McbEdu.Mentorias.ShopDemo.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IImportCustomerService, ImportCustomerService>();
        return services;
    }
}