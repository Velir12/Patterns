using Norbit.GCRM.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORBIT.GCRM.Decorator
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order: CreatioBaseEntity
    {
        #region Свойства.

        /// <summary>
        /// Цена заказа.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Заказчик.
        /// </summary>
        public Client Сustomer { get; set; }

        /// <summary>
        /// Состояние заказа.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Ответственный за заказ сотрудник.
        /// </summary>
        public Employee Owner { get; set; }

        #endregion

        public Order(Guid id, int price, string status, Client customer, Employee owner): base(id)
        {
            Price = price;
            Status = status;
            Owner = owner;
            Сustomer = customer;
        }

        /// <summary>
        /// Получение информации о заказе.
        /// </summary>
        /// <returns></returns>
        public string GetOrderInfo()
        {
            var sb = new StringBuilder();
            sb.Append("Договор:\n" + base.ToString());
            sb.Append($"\nЗаказчик:\n{Сustomer}\n");
            sb.Append($"\nОтветственный за заказ:\n{Owner}\n");
            sb.Append($"Цена заказа: {Price}\n");
            sb.Append($"Статус заказа: {Status}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
