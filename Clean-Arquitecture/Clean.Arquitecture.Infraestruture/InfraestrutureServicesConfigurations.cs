using Clean.Arquitectucture.Aplication.Contracts;
using Clean.Arquitecture.Infraestruture.Persistence;
using Clean.Arquitecture.Infraestruture.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Clean.Arquitecture.Infraestruture
{
    public static class InfraestrutureServicesConfigurations
    {
        public static IServiceCollection AddInfraestructureServices(
                                            this IServiceCollection services,
                                            IConfiguration configuration)
        {
            services.AddDbContext<CleanArquitectureDbContext>(option =>
                    option.UseSqlServer(configuration
                                    .GetConnectionString("ConnectionString")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));

            return services;
        }
    }
}
