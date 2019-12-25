using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.DataBaseContext
{
    public class CreatioTestContext: DbContext
    {
        /// <summary>
        /// Логгер
        /// </summary>
        private readonly ILogger<CreatioTestContext> _Logger;

        /// <summary>
        /// Список записей в таблице Contact
        /// </summary>
        public DbSet<Contact> Contact { get; set; }

        /// <summary>
        /// Инициализация контекста
        /// </summary>
        /// <param name="logger">Логгер</param>
        public CreatioTestContext(ILogger<CreatioTestContext> logger, DbContextOptions<CreatioTestContext> options)
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
