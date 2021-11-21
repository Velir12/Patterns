using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AbstractFacrotyConsoleApp
{
    /// <summary>
    /// Клиент, определяющий какой продукт надо создать.
    /// </summary>
    public class Client
    {
        #region Свойства

        /// <summary>
        /// Телефон.
        /// </summary>
        public AbstractPhone phone;

        /// <summary>
        /// Наушники.
        /// </summary>
        public AbstractHeadPhones headPhones;

        /// <summary>
        /// Зарядка.
        /// </summary>
        public AbstractCharging charging;

        #endregion

        /// <summary>
        /// Конструктор, создающий продукты.
        /// </summary>
        /// <param name="factory"> Фабрика, которая будет использоваться для создания.</param>
        public Client(AbstractFactory factory)
        {
            phone = factory.CreatePhone();
            headPhones = factory.CreateHeadPhones();
            charging = factory.CreateCharging();
        }

        /// <summary>
        /// Приведение информации о продуктах в строку.
        /// </summary>
        /// <returns> Информацию о продуктах.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Информация о телефоне:\n");
            sb.Append(phone);
            sb.Append("Информация о наушниках: \n");
            sb.Append(headPhones);
            sb.Append("Информация о зарядке: \n");
            sb.Append(charging);
            return sb.ToString();
        }
    }
}
