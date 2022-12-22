using McbEdu.Mentorias.ShopDemo.Application.Common.Interfaces.Persistence;
using McbEdu.Mentorias.ShopDemo.Infrastructure.Persistence;

using Microsoft.Extensions.DependencyInjection;

namespace McbEdu.Mentorias.ShopDemo.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services )
    {
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        return services;
    }
}