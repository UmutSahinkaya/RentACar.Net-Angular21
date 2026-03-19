using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using RentCarServer.Application.Behaviors;
using RentCarServer.Application.Services;
using TS.MediatR;

namespace RentCarServer.Application;

public static class ServiceRegistrar
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        _ = services.AddScoped<PermissionService>();
        _ = services.AddScoped<PermissionCleanerService>();
        _ = services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(typeof(ServiceRegistrar).Assembly);
            cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));
            cfg.AddOpenBehavior(typeof(PermissionBehavior<,>));
        });
        _ = services.AddValidatorsFromAssembly(typeof(ServiceRegistrar).Assembly);
        return services;
    }
}
