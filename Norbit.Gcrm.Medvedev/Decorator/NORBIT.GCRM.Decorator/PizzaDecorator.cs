using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Decorator
{
    /// <summary>
    /// Декоратор пиццы.
    /// </summary>
    public abstract class PizzaDecorator : Pizza
    {
        /// <summary>
        /// Пицца.
        /// </summary>
        protected Pizza pizza;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"> Имя пиццы.</param>
        /// <param name="pizza"> Пицца.</param>
        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            this.pizza = pizza;
        }
    }

    /// <summary>
    /// Грибная пиццы.
    /// </summary>
    public class MushroomPizza : PizzaDecorator
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="pizza"> Пицца, к которой будут добавляться грибы.</param>
        public MushroomPizza(Pizza pizza) : base("Грибная " + pizza.Name, pizza)
        {

        }

        /// <summary>
        /// Получение цены пиццы.
        /// </summary>
        /// <returns></returns>
        public override int GetCost()
        {
            return pizza.GetCost() + 2;
        }
    }

}
