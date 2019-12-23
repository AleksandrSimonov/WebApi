using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


namespace WebApi
{
    /// <summary>
    /// Является входной точкой в приложение ASP.NET Core. 
    /// Этот класс производит конфигурацию приложения, настраивает сервисы, которые приложение будет использовать, 
    /// устанавливает компоненты для обработки запроса или middleware.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// устанавливает начальную конфигурацию приложения.
        /// </summary>
        /// <param name="configuration">начальная конфигурация приложения</param>
        public Startup(IConfiguration configuration)
        {
            _Configuration = configuration;
        }

        /// <summary>
        /// Конфигурация
        /// </summary>
        private readonly IConfiguration _Configuration;

        /// <summary>
        /// Добавляет контроллеры в метод
        /// </summary>
        /// <param name="services">Сервис</param>
        public void ConfigureServices(IServiceCollection services)
        {
            if (services == null)
            {
                throw new NullReferenceException("services не может быть null");
            }
            services.AddControllers();
            services.AddDbContext<CreateoTestContext>(options => options.UseSqlServer(_Configuration.GetConnectionString("ConnectionStrings")));
        }

        /// <summary>
        ///  устанавливает, как приложение будет обрабатывать запрос
        /// </summary>
        /// <param name="app"> Содержит методы для установки компонентов, которые обрабатывают запрос</param>
        /// <param name="env">Представляет собой информацию о среде, в которой запускается приложение</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
