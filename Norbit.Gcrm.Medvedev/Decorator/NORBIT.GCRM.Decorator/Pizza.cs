using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Decorator
{
    /// <summary>
    /// Пицца.
    /// </summary>
    public abstract class Pizza
    {

        /// <summary>
        /// Название пиццы.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"> Имя пиццы.</param>
        public Pizza(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Получение цены пиццы.
        /// </summary>
        /// <returns> Цену.</returns>
        public abstract int GetCost();

        /// <summary>
        /// Приведение всей информации о пицце в строку.
        /// </summary>
        /// <returns> Информацию о пицце.</returns>
        public override string ToString()
        {
            return Name + " стоимостью " + GetCost();
        }
    }

    #region Классы пиццы.

    /// <summary>
    /// Американская пицца.
    /// </summary>
    public class AmericanPizza : Pizza
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public AmericanPizza() : base("Американская пицца")
        {

        }

        /// <summary>
        /// Получение цены пиццы.
        /// </summary>
        /// <returns>Цена пиццы.</returns>
        public override int GetCost()
        {
            return 10;
        }
    }

    /// <summary>
    /// Итальянская пицца.
    /// </summary>
    public class ItalianPizza : Pizza
    {
        /// <summary>
        /// Констуктор пиццы.
        /// </summary>
        public ItalianPizza() : base("Итальянская пицца")
        {

        }

        /// <summary>
        /// Полчение цены пиццы.
        /// </summary>
        /// <returns> Цена пиццы.</returns>
        public override int GetCost()
        {
            return 5;
        }
    }

    #endregion
}
