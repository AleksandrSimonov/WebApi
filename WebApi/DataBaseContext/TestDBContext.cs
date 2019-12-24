using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using WebApi.Models;

namespace WebApi.DataBaseContext
{
    /// <summary>
    /// Класс для взаимодействия с баззой данных
    /// </summary>
    public class TestDBContext : DbContext
    {
        /// <summary>
        /// Логгер
        /// </summary>
        private readonly ILogger<TestDBContext> _Logger;

        /// <summary>
        /// Список записей в таблице Person
        /// </summary>
        public DbSet<Person> Person { get; set; }

        /// <summary>
        /// Инициализация контекста
        /// </summary>
        /// <param name="logger">Логгер</param>
        public TestDBContext(ILogger<TestDBContext> logger, DbContextOptions<TestDBContext> options)
            : base(options)
        {
            if (logger == null)
            {
                string error = LogConst.LoggerIsNotInitialized;
                _Logger.LogError(error);
                throw new NullReferenceException(error);
            }
            _Logger = logger;
        }
    }
}
