using FarmaMed.DomainModel.Interfaces.Repositories;
using FarmaMed.DomainModel.Interfaces.Services;
using FarmaMed.DomainModel.Interfaces.UoW;
using FarmaMed.DomainService;
using FarmaMed.Infra.Context;
using FarmaMed.Infra.Repository;
using FarmaMed.Infra.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace FarmaMed.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddDbContext<FarmaMedContext>();
            services.AddScoped<IUnitOfWork, EntityFrameworkUnitOfWork>();

            services.AddScoped<IMedicamentoService, MedicamentoService>();
            services.AddScoped<ISintomaService, SintomaService>();

            services.AddScoped<IMedicamentoRepository, MedicamentoRepository>();
            services.AddScoped<ISintomaRepository, SintomaRepository>();

            return services;
        }
    }
}
