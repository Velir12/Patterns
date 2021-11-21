using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Norbit.GCRM.Medvedev.AbstractFacrotyConsoleApp
{
    /// <summary>
    /// Абстрактная фабрика.
    /// </summary>
    public abstract class AbstractFactory
    {
        #region Методы абстрактной фабрики.

        /// <summary>
        /// Создать телефон.
        /// </summary>
        /// <returns> Телефон.</returns>
        public abstract AbstractPhone CreatePhone();

        /// <summary>
        /// Создать наушники.
        /// </summary>
        /// <returns>< Нашуники.</returns>
        public abstract AbstractHeadPhones CreateHeadPhones();

        /// <summary>
        /// Создать зарядку.
        /// </summary>
        /// <returns> Зарядку.</returns>
        public abstract AbstractCharging CreateCharging();

        #endregion
    }

    #region Классы связанные с абстрактной фабрикой.

    /// <summary>
    /// Абстрактный телефон.
    /// </summary>
    public abstract class AbstractPhone
    {
        #region Свойства

        /// <summary>
        /// Название телфона.
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// Тип системы.
        /// </summary>
        protected string OSType { get; set; }

        /// <summary>
        /// Количество памяти в Мб.
        /// </summary>
        protected int Memory { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        protected int Price { get; set; }

        #endregion

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Телефон: {Name}\n");
            sb.Append($"Тип ОС: {OSType}\n");
            sb.Append($"Количество памяти (Мб): {Memory}\n");
            sb.Append($"Цена: {Price}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// Абтсрактные наушники.
    /// </summary>
    public abstract class AbstractHeadPhones
    {
        #region Свойства

        /// <summary>
        /// Название наушников.
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        protected int Price { get; set; }

        #endregion

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Наушники: {Name}\n");
            sb.Append($"Цена: {Price}\n");
            return sb.ToString();
        }
    }
    
    /// <summary>
    /// Абстрактная зарядка.
    /// </summary>
    public abstract class AbstractCharging
    {
        #region Свойства

        /// <summary>
        /// Тип зарядки.
        /// </summary>
        protected string Type { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        protected int Price { get; set; }

        #endregion

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Тип зарядки: {Type}\n");
            sb.Append($"Цена: {Price}\n");
            return sb.ToString();
        }
    }

    #endregion
}