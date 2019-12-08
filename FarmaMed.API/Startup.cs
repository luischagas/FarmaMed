using FarmaMed.DomainModel.Interfaces.Repositories;
using FarmaMed.DomainModel.Interfaces.Services;
using FarmaMed.DomainModel.Interfaces.UoW;
using FarmaMed.DomainService;
using FarmaMed.Infra.Context;
using FarmaMed.Infra.Repository;
using FarmaMed.Infra.UoW;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace FarmaMed.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()
                .AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<FarmaMedContext>(opts =>
            {
                opts.UseSqlServer(Configuration.GetConnectionString("Default"));
            });

            services.AddScoped<IUnitOfWork, EntityFrameworkUnitOfWork>();

            services.AddScoped<IMedicamentoService, MedicamentoService>();
            services.AddScoped<ISintomaService, SintomaService>();

            services.AddScoped<IMedicamentoRepository, MedicamentoRepository>();
            services.AddScoped<ISintomaRepository, SintomaRepository>();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
