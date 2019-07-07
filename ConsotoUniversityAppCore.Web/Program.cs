using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ConsotoUniversityAppCore.Web.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ConsotoUniversityAppCore.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Build một Webhost
            var host = CreateWebHostBuilder(args).Build();
            // Tạo scope để phân giải ra các service trong scope
            using (var scope = host.Services.CreateScope())
            {
                // Lấy về một Service dependency Injection có đăng ký
                var services = scope.ServiceProvider;
                try
                {
                    // lấy về context SQL có đăng ký như là một DI Service.
                    var context = services.GetRequiredService<SchoolContext>();
                    // Khởi tạo database
                    DbInitializer.Initialize(context);

                }
                catch (Exception ex)
                {
                    var logger=services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
                

            }
            host.Run();
            
        }
        /// <summary>
        /// Tạo Webhostbuilder.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
                
    }
}
