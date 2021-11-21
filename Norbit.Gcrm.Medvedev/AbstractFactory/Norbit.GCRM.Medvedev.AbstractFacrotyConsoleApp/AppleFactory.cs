using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Norbit.GCRM.Medvedev.AbstractFacrotyConsoleApp
{
    /// <summary>
    /// Фабрика Apple.
    /// </summary>
    public class AppleFactory : AbstractFactory
    {
        /// <summary>
        /// Создание зарядки Apple.
        /// </summary>
        /// <returns> Зарядку Apple.</returns>
        public override AbstractCharging CreateCharging()
        {
            return new AppleCharging();
        }

        /// <summary>
        /// Создание наушников Apple.
        /// </summary>
        /// <returns> Нашуники Apple.</returns>
        public override AbstractHeadPhones CreateHeadPhones()
        {
            return new AirPods();
        }

        /// <summary>
        /// Создание телефона Apple.
        /// </summary>
        /// <returns> Телефон Apple.</returns>
        public override AbstractPhone CreatePhone()
        {
            return new IPhone();
        }
    }

    #region Классы фабрики Apple.

    /// <summary>
    /// Телефон Apple.
    /// </summary>
    public class IPhone : AbstractPhone
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public IPhone()
        {
            Name = "IPhone 6S";
            OSType = "IOS 8";
            Memory = 4096;
            Price = 20000;
        }
    }

    /// <summary>
    /// Нашуники Apple.
    /// </summary>
    public class AirPods : AbstractHeadPhones
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public AirPods()
        {
            Name = "AirPods";
            Price = 10000;
        }
    }

    /// <summary>
    /// Зарядка Apple.
    /// </summary>
    public class AppleCharging : AbstractCharging
    {
        /// <summary>
        /// КОнструктор.
        /// </summary>
        public AppleCharging()
        {
            Type = "Lightning";
            Price = 3500;
        }
    }

    #endregion


}