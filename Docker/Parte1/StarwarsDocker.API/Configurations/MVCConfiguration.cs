using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace StarwarsDocker.API.Configurations
{
    public static class MVCConfiguration
    {
        public static IServiceCollection AddMVCConfiguration(this IServiceCollection services)
        {
            services
                .AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            return services;
        }

        public static IApplicationBuilder UseMVCConfiguration(this IApplicationBuilder app)
        {
            return app
                .UseMvc();
        }
    }
}
