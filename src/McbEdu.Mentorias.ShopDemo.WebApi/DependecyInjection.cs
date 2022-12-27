using McbEdu.Mentorias.ShopDemo.WebApi.Common.Errors;
using McbEdu.Mentorias.ShopDemo.WebApi.Common.Mapping;

using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace McbEdu.Mentorias.ShopDemo.WebApi;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, ShopDemoProblemDetailsFactory>();
        services.AddMappings();
        return services;
    }
}