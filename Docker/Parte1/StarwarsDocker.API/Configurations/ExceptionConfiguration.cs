using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace StarwarsDocker.API.Configurations
{
    public static class ExceptionConfiguration
    {
        public static IApplicationBuilder UseExceptionConfiguration(this IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            return app;
        }
    }
}
