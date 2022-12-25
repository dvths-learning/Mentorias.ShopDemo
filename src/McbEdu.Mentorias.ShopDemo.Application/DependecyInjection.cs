using McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers.Commands;

using Microsoft.Extensions.DependencyInjection;

namespace McbEdu.Mentorias.ShopDemo.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IImportCustomerCommandService, ImportCustomerCommandService>();
        return services;
    }
}