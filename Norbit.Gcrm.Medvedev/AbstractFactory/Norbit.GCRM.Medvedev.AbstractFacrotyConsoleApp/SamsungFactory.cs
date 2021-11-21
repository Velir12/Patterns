using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Norbit.GCRM.Medvedev.AbstractFacrotyConsoleApp
{
    /// <summary>
    /// Фабрика Samsung.
    /// </summary>
    public class SamsungFactory : AbstractFactory
    {
        /// <summary>
        /// Создание зарядки Samsung.
        /// </summary>
        /// <returns> Зарядку.</returns>
        public override AbstractCharging CreateCharging()
        {
            return new SamsungCharging();
        }

        /// <summary>
        /// Создание нашуников Samsung.
        /// </summary>
        /// <returns> Нашуники.</returns>
        public override AbstractHeadPhones CreateHeadPhones()
        {
            return new GalaxyBuds();
        }

        /// <summary>
        /// Создание телефона Samsung.
        /// </summary>
        /// <returns> Телефон.</returns>
        public override AbstractPhone CreatePhone()
        {
            return new Galaxy();
        }
    }

    #region Классы фабрики Самсунг

    /// <summary>
    /// Телефон Samsung.
    /// </summary>
    public class Galaxy : AbstractPhone
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public Galaxy()
        {
            Name = "Galaxy S8";
            OSType = "Android 8";
            Memory = 4096;
            Price = 15000;
        }
    }

    /// <summary>
    /// Наушники Samsung.
    /// </summary>
    public class GalaxyBuds : AbstractHeadPhones
    {
        /// <summary>
        /// Наушники Самсунг.
        /// </summary>
        public GalaxyBuds()
        {
            Name = "Galaxy Buds";
            Price = 5000;
        }
    }

    /// <summary>
    /// Зарядка Samsung.
    /// </summary>
    public class SamsungCharging : AbstractCharging
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public SamsungCharging()
        {
            Type = "Type C";
            Price = 1500;
        }
    }

    #endregion
}