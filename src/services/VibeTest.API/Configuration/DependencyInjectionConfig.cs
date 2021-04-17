using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VibeTest.API.Application;
using VibeTest.API.Application.Interfaces;
using VibeTest.Core.Objects.Integration;
using VibeTest.Infra.Integration.Adapter;
using VibeTest.Infra.Integration.Adapter.Interfaces;
using VibeTest.Infra.Integration.Services;
using VibeTest.Infra.Integration.Services.Interfaces;

namespace VibeTest.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterDependenciesServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IIntegrationModel>(x => x.GetRequiredService<IOptions<IntegrationModel>>().Value);

            services.AddHttpClient<IParlamentarService, ParlamentarService>
                (b => b.BaseAddress = new Uri(configuration["IntegrationConfig:RequestUrl"]));

            services.AddScoped<IParlamentarApplication, ParlamentarApplication>();

            services.AddScoped<IParlamentarAdapter, ParlamentarAdapter>();
            services.AddScoped<IParlamentarDetalhesAdapter, ParlamentarDetalhesAdapter>();
            services.AddScoped<IParlamentarDespesasAdapter, ParlamentarDespesasAdapter>();
        }
    }
}
