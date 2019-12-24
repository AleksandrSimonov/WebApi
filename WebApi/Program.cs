using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System.Configuration;

namespace WebApi
{
    /// <summary>
    /// Точка входа проекта
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Начальная точка входа приложения
        /// </summary>
        /// <param name="args">аргументы командной строки</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// устанавливает класс Startup в качестве стартового
        /// </summary>
        /// <param name="args">входные аргументы</param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
