using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using WebApi.Tables;

namespace WebApi
{
    /// <summary>
    /// Класс для взаимодействия с баззой данных
    /// </summary>
    public class CreateoTestContext : DbContext
    {
        /// <summary>
        /// Логгер
        /// </summary>
        private readonly ILogger<CreateoTestContext> _Logger;

        /// <summary>
        /// Список записей в таблице Person
        /// </summary>
        public DbSet<Person> Person { get; set; }

        /// <summary>
        /// Инициализация контекста
        /// </summary>
        /// <param name="logger">Логгер</param>
        public CreateoTestContext(ILogger<CreateoTestContext> logger, DbContextOptions<CreateoTestContext> options)
            : base(options)
        {
            if (logger == null)
            {
                string error = "Логгер не инициализирован";
                _Logger.LogError(error);
                throw new NullReferenceException(error);
            }
            _Logger = logger;
        }

        /// <summary>
        /// Выполняет подключение к БД
        /// </summary>
        /// <param name = "optionsBuilder" > позволяет создать параметры подключения</param>
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
        //        var appConfiguration = builder.Build();

        //        try
        //        {
        //            optionsBuilder.UseSqlServer(appConfiguration["ConnectionString"]);
        //            _Logger.LogInformation("Подключение к БД выполнено успешно");
        //        }
        //        catch (Exception ex)
        //        {
        //            _Logger.LogError(ex, "ошибка подключения к БД");
        //        }
        //    }
        //    else
        //    {
        //        string error = "optionsBuilder не может быть null";
        //        _Logger.LogError(error);
        //        throw new NullReferenceException(error);
        //    }
        //}

    }
}
