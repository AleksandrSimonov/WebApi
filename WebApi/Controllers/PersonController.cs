﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using WebApi.Tables;

namespace WebApi.Controllers
{
    /// <summary>
    /// Контроллер, предоставляющий api к таблице Person
    /// </summary>
    [Produces("application/json")] // для отправки данных в формате json
    [ApiController]
    [Route("[controller]")] // содержит шаблон URL, который сопоставляется с этим контроллером. 
    public class PersonController : ControllerBase
    {
        /// <summary>
        /// Имя таблицы в БД
        /// </summary>
        private const string TableName = "Person";

        /// <summary>
        /// Логгер контроллера
        /// </summary>
        private readonly ILogger<PersonController> _Logger;

        /// <summary>
        /// Контекст базы данных
        /// </summary>
        private readonly CreateoTestContext _DBContext;

        /// <summary>
        /// Инициализация контроллера
        /// </summary>
        /// <param name="logger">Логгер</param>
        public PersonController(ILogger<PersonController> logger, CreateoTestContext db)
        {
            if (logger == null)
            {
                throw new NullReferenceException(LogConst.Errors.LoggerIsNotInitialized);
            }
            if (db == null)
            {
                throw new NullReferenceException(LogConst.Errors.ContextIsNotInitialized);
            }
            _Logger = logger;
            _DBContext = db;
        }

        /// <summary>
        /// Возвращает всю таблицу Person из БД
        /// </summary>
        /// <returns>массив записией в таблице Person</returns>
        [Route("~/api/Select")]
        [HttpGet]
        public Person[] Select()
        {
             var persons = _DBContext.Person.ToList();
            _Logger.LogInformation(LogConst.Info.GetAllPersons);
            return persons.ToArray();
        }

        /// <summary>
        /// Получает одну запись таьлицы Peerson по id
        /// </summary>
        /// <param name="id">Уникальный идентификатор в таблице Person</param>
        /// <returns></returns>
        [Route("~/api/Select/{id}")]
        [HttpGet]
        public Person Select(int id)
        {
            if (id < 0)
            {
                _Logger.LogError(LogConst.Errors.IdIsNegative);
                throw new ArgumentException(LogConst.Errors.IdIsNegative);
            }
            var person = _DBContext.Person.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                _Logger.LogInformation(LogConst.Info.ElementNotFound(id,TableName));
            }
            _Logger.LogInformation(LogConst.Info.ElementIsFound(id, TableName));
            return person;

        }

        /// <summary>
        /// Производт добавление новой записи. Если такая уже существует, то производит обновление
        /// </summary>
        /// <param name="pers">экземпляр новой записи Person</param>
        /// <returns></returns>
        [Route("~/api/InsertOrUpdate")]
        [HttpPut]
        public string InsertOrUpdate(Person pers)
        {
            if (pers == null)
            {
                _Logger.LogError(LogConst.Errors.ValueCannotBeNull);
                throw new ArgumentException(LogConst.Errors.ValueCannotBeNull);
            }
            var person = _DBContext.Person.FirstOrDefault(p => p.Id == pers.Id);
            if (person == null)
            {
                try
                {
                    _DBContext.Person.Add(pers);
                    _DBContext.SaveChanges();
                    _Logger.LogInformation(LogConst.Info.AddedElement(TableName));
                    return "Элемент добавлен в БД";
                } catch (Exception ex)
                {
                    _Logger.LogError(ex, LogConst.Errors.ElementNotAdded(TableName));
                    return "Произошла ошибка при добавении в бд";
                }
            }
            else
            {
                try
                {
                    person.Name = pers.Name;
                    _DBContext.Person.Update(person);
                    _DBContext.SaveChanges();
                    _Logger.LogInformation(LogConst.Info.ElementUpdated(pers.Id, TableName));
                    return "Элемент обновлен";
                } catch (Exception ex)
                {
                    _Logger.LogError(LogConst.Errors.ElementNotUpdated(pers.Id, TableName));
                    return "Произошла ошибка при обновлении бд";
                }

            }
        }

        /// <summary>
        /// Производит удаление записи из таблице Person по id
        /// </summary>
        /// <param name="id">Уникальный идентификатор в таблие Person</param>
        /// <returns></returns>
        [Route("~/api/Delete/{id}")]
        [HttpDelete]
        public string Delete(int id)
        {
            if (id < 0)
            {
              
                _Logger.LogError(LogConst.Errors.IdIsNegative);
                throw new ArgumentException(LogConst.Errors.IdIsNegative);
            }

            var person = _DBContext.Person.FirstOrDefault(p => p.Id == id);
            if (person != null)
            {
                try
                {
                    _DBContext.Person.Remove(person);
                    _DBContext.SaveChanges();
                    _Logger.LogInformation(LogConst.Info.ElementDeleted(id, TableName));
                    return "Элемент успешно удален";
                }
                catch (Exception ex)
                {
                    _Logger.LogError(ex, LogConst.Errors.ElementNotDeleted(id, TableName));
                    return "Произошла ошибка при удалении из бд";
                }
            }
            else
            {
                _Logger.LogInformation(LogConst.Info.ElementNotFound(id, TableName));
                return "Элемент не найден";
            }

        }
    } 
}
