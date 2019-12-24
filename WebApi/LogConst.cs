using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    /// <summary>
    /// Содержит константы логгера
    /// </summary>
    public static class LogConst
    {
        /// <summary>
        /// Services не может быть null
        /// </summary>
        public static string ParamCannotBeNull(string paramName)
        {
            return $"{paramName} null не может быть null";
        }

        /// <summary>
        /// Логгер не инициализирован
        /// </summary>
        public static string LoggerIsNotInitialized
        {
            get
            {
                return "Логгер не инициализирован";
            }
        }

        /// <summary>
        /// Контекст не инициализирован
        /// </summary>
        public static string ContextIsNotInitialized
        {
            get
            {
                return "Контекст не инициализирован";
            }
        }

        /// <summary>
        /// id не может быть отрицательным
        /// </summary>
        public static string IdIsNegative
        {
            get
            {
                return "id не может быть отрицательным";
            }
        }

        /// <summary>
        /// Значение не может быть нулевым
        /// </summary>
        public static string ParamCannotBeZero(string paramName)
        {
            return $"{paramName} не может быть нулевым";
        }

        /// <summary>
        /// Произошла ошибка при добавении в таблицу
        /// </summary>
        /// <param name="tableName">Имя таблицы, в которую производилось добавление</param>
        /// <returns></returns>
        public static string ElementNotAdded(string tableName)
        {
            return $"Произошла ошибка при добавении в {tableName}";
        }

        /// <summary>
        /// Элемент не обнавлен
        /// </summary>
        /// <param name="id">id элемнта</param>
        /// <param name="tableName">таблица, в которой производилось обновление элемента</param>
        /// <returns></returns>
        public static string ElementNotUpdated(int id, string tableName)
        {
            return $"Ошибка при обновлении элемента с id= {id} таблицы  {tableName}";
        }

        /// <summary>
        /// Ошибка при удалении элемента
        /// </summary>
        /// <param name="id">id элемнта</param>
        /// <param name="tableName">таблица, в которой производилось удаление элемента</param>
        /// <returns></returns>
        public static string ElementNotDeleted(int id, string tableName)
        {
            return $"Ошибка при удалении элемента с id= {id} таблицы  {tableName}";
        }

        /// <summary>
        /// По запросу пользователя выдана вся таблица Person
        /// </summary>
        public static string GetAllPersons
        {
            get
            {
                return "По запросу пользователя выдана вся таблица Person";
            }
        }

        /// <summary>
        /// Элемент в БД не найден
        /// </summary>
        /// <param name="id">id элемнта</param>
        /// <param name="tableName">таблица, в которой был поиск</param>
        /// <returns></returns>
        public static string ElementNotFound(int id, string tableName)
        {
            return $"По запросу пользователя элемент с id = { id } таблицы {tableName} не найден";
        }

        /// <summary>
        /// Элемент в БД не найден
        /// </summary>
        /// <param name="id">id элемнта</param>
        /// <param name="tableName">таблица, в которой был поиск</param>
        /// <returns></returns>
        public static string ElementIsFound(int id, string tableName)
        {
            return $"По запросу пользователя выдаy элемент с id= {id} таблицы {tableName}";
        }

        /// <summary>
        /// Добавлен элемент в таблицу Person
        /// </summary>
        /// <param name="tableName">таблица, в которую был добавлен элемент</param>
        /// <returns></returns>
        public static string AddedElement(string tableName)
        {
            return $"Добавлен элемент в таблицу {tableName}";
        }

        /// <summary>
        /// Элемент таблицы обнавлн
        /// </summary>
        /// <param name="id">id элемнта</param>
        /// <param name="tableName">таблица, в которой был обновлен элемент</param>
        /// <returns></returns>
        public static string ElementUpdated(int id, string tableName)
        {
            return $"Элемент с id= {id} таблицы  {tableName} обновлен";
        }

        /// <summary>
        /// Элемент удален
        /// </summary>
        /// <param name="id">id элемнта</param>
        /// <param name="tableName">таблица, в которой был удален элемент</param>
        /// <returns></returns>
        public static string ElementDeleted(int id, string tableName)
        {
            return $"Элемент с id= {id} таблицы  {tableName} удален";
        }
    }
}

