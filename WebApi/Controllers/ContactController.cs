using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.DataBaseContext;

namespace WebApi.Controllers
{    
     /// <summary>
     /// Контроллер, предоставляющий api к таблице Contact
     /// </summary>
    [Produces("application/json")] // для отправки данных в формате json
    [ApiController]
    [Route("[controller]")] // содержит шаблон URL, который сопоставляется с этим контроллером. 
    public class ContactController : ControllerBase
    {

        /// <summary>
        /// Логгер контроллера
        /// </summary>
        private readonly ILogger<PersonController> _Logger;

        /// <summary>
        /// Контекст базы данных
        /// </summary>
        private readonly CreatioTestContext _DBContext;

        /// <summary>
        /// Инициализация контроллера
        /// </summary>
        /// <param name="logger">Логгер</param>
        public ContactController(ILogger<PersonController> logger, CreatioTestContext dataBaseContext)
        {
            if (logger == null)
            {
                throw new NullReferenceException(LogConst.LoggerIsNotInitialized);
            }
            if (dataBaseContext == null)
            {
                throw new NullReferenceException(LogConst.ContextIsNotInitialized);
            }

            _Logger = logger;
            _DBContext = dataBaseContext;
        }

        /// <summary>
        /// Возвращает всю таблицу Contact из БД
        /// </summary>
        /// <returns>массив записией в таблице Contact</returns>
        [Route("~/CreatioTestDB/Contact/Select")]
        [HttpGet]
        public Contact[] Select()
        {
            var x = _DBContext.Contact;
            var contacts = _DBContext.Contact.ToList();
            _Logger.LogInformation(LogConst.GotEntireTable(nameof(_DBContext.Contact)));
            return contacts.ToArray();
        }
    }
}
