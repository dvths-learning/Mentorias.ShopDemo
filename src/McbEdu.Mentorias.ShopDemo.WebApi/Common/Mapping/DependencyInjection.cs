using System.Reflection;

using Mapster;

using MapsterMapper;
namespace McbEdu.Mentorias.ShopDemo.WebApi.Common.Mapping;

public static class DependencyInjection
{
    public static IServiceCollection AddMappings(this IServiceCollection services)
    {
        // garantir o assembly é escaneado encontrando todas as interfaces de configuração
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton(config);

        // ServiceMapper é o serviço com abstrações para injeção de dependência
        services.AddScoped<IMapper, ServiceMapper>();

        return services;
    }
}