using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace WorldData
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

    }

    public static class DBConfiguration
    {
        public static string ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=world;";
        // public static string ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=todo;";
        // ID AND PASSWORD ARE GOING TO BE WRONG!
    }

}
