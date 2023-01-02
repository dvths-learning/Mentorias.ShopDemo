using System.Reflection;

using ErrorOr;

using FluentValidation;

using McbEdu.Mentorias.ShopDemo.Application.Common.Behaviors;
using McbEdu.Mentorias.ShopDemo.Application.Import.Commands.ImportOneCustomerCommand;
using McbEdu.Mentorias.ShopDemo.Application.Import.Common;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace McbEdu.Mentorias.ShopDemo.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);

        services.AddScoped(
            typeof(IPipelineBehavior<,>),
            typeof(ValidationBehavior<,>));

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}