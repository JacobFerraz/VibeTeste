using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VibeTest.Core.Objects.Integration;

namespace VibeTest.API.Configuration
{
    public static class IntegrationConfig
    {
        public static IServiceCollection IntegrationConfiguration(this IServiceCollection services, IConfiguration configurarion)
        {
            services.Configure<IntegrationModel>(configurarion.GetSection(nameof(IntegrationConfig)));

            return services;
        }
    }
}
