using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SMacedo.Teste.Domain.Contracts;
using SMacedo.Teste.Infra.SQLServerClient.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace SMacedo.Teste.Infra.IoC
{
    [ExcludeFromCodeCoverage]
    public static class IoCDatabaseExtension
    {
        public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            serviceCollection.AddDbContext<ILeadsContext, LeadsContext>(options => {
                options.UseSqlServer(
                    connectionString,
                    config =>
                    {
                        config.MigrationsAssembly(Assembly.GetAssembly(typeof(LeadsContext))?.FullName);
                        config.CommandTimeout(120);
                    }
                );
            }, contextLifetime: ServiceLifetime.Singleton, optionsLifetime: ServiceLifetime.Singleton);

            return serviceCollection;
        }
    }
}
