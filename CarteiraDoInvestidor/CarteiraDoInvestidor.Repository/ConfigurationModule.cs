using CarteiraDoInvestidor.Repository.Context;
using CarteiraDoInvestidor.Repository.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarteiraDoInvestidor.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CarteiraDoInvestidorContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));


            return services;
        }
    }
}
