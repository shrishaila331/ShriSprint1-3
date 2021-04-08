using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectManagement.Shared;

namespace ProjectManagement.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<PMContext>();
                DataSeeder.Initialize(services);
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        internal class DataSeeder
        {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                var contextOptions = serviceProvider.GetRequiredService<DbContextOptions<PMContext>>();
                var context = new PMContext(contextOptions);
                DataService.SeedData(context);
            }
        }
    }

    
}
