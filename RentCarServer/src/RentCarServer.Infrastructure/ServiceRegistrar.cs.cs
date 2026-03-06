using GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RentCarServer.Infrastructure.Context;
using RentCarServer.Infrastructure.Options;
using RentCarServer.WebAPI.Options;
using Scrutor;

namespace RentCarServer.Infrastructure;

public static class ServiceRegistrar
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        _ = services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

        _ = services.Configure<JwtOptions>(configuration.GetSection("Jwt"));
        _ = services.ConfigureOptions<JwtSetupOptions>();
        _ = services.AddAuthentication().AddJwtBearer();
        _ = services.AddAuthorization();

        _ = services.Configure<MailSettingOptions>(configuration.GetSection("EmailSettings"));
        using var scoped = services.BuildServiceProvider().CreateScope();
        var mailSettings = scoped.ServiceProvider.GetRequiredService<IOptions<MailSettingOptions>>().Value;
        if (string.IsNullOrEmpty(mailSettings.Username))
        {
            _ = services.AddFluentEmail(mailSettings.Email).AddSmtpSender(mailSettings.SmtpServer, mailSettings.Port);
        }
        else
        {
            _ = services.AddFluentEmail(mailSettings.Email).AddSmtpSender(mailSettings.SmtpServer, mailSettings.Port, mailSettings.Username, mailSettings.Password);
        }


        _ = services.Scan(scan => scan
            .FromAssemblies(typeof(ServiceRegistrar).Assembly)
            .AddClasses(publicOnly: false)
            .UsingRegistrationStrategy(RegistrationStrategy.Skip)
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        _ = services.AddScoped<IUnitOfWork>(srv => srv.GetRequiredService<ApplicationDbContext>());

        return services;
    }
}
