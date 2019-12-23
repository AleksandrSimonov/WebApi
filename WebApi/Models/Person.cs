using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Tables
{
    /// <summary>
    /// Модель таблицы в БД
    /// </summary>
    public class Person
    {
        /// <summary>
        /// создание новой записи
        /// </summary>
        /// <param name="id"> уникальный идентификатор</param>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="phoneNumber">Номер телефона</param>
        public Person(int id, string name, int age, string phoneNumber)
        {
            if (id < 0)
            {
                throw new ArgumentException("id не может быть отрицательным");
            }
            if (name == null || name == "")
                throw new ArgumentException("name не может быть пустой строкой или null");
            if (age < 0)
                throw new ArgumentException("age не может быть отрицательным");

            Id = id;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public Person() { }


        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Телнфонный номер
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
