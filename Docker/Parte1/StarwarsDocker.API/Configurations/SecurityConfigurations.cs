using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace StarwarsDocker.API.Configurations
{
    public static class SecurityConfigurations
    {
        public static IApplicationBuilder UseHttpsRedirectConfiguration(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            return app;
        }

        public static IApplicationBuilder UseHstsConfiguration(this IApplicationBuilder app, IHostingEnvironment env)
        {
            if(!env.IsDevelopment())
            {
                app.UseHsts();
            }
            
            return app;
        }
    }
}
