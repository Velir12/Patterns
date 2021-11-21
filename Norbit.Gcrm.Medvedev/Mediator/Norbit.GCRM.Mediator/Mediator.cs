using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Mediator
{
    /// <summary>
    /// Медиатор.
    /// </summary>
    public abstract class Mediator
    {
        /// <summary>
        /// Отправить сообщение через посредникаю
        /// </summary>
        /// <param name="msg"> Текст сообщения.</param>
        /// <param name="subordinate"> Отправитель сообщение.</param>
        public abstract void SendInformation(string msg, Subordinate subordinate);
    }

    /// <summary>
    /// Менеджер.
    /// </summary>
    public class Manager : Mediator
    {
        #region Свойства менеджера.

        /// <summary>
        /// Заказчик.
        /// </summary>
        public Subordinate Customer { get; set; }

        /// <summary>
        /// Программист.
        /// </summary>
        public Subordinate Programmer { get; set; }

        /// <summary>
        /// Аналитик.
        /// </summary>
        public Subordinate Analyst { get; set; }

        #endregion

        /// <summary>
        /// Отправка информации одному из подчиненных.
        /// </summary>
        /// <param name="msg"> Сообщение.</param>
        /// <param name="subordinate"> Подчиненный.</param>
        public override void SendInformation(string msg, Subordinate subordinate)
        {
            if (Customer == subordinate)
            {
                Analyst.Notify(msg);
            }
            else if (Analyst == subordinate)
            {
                Programmer.Notify(msg);
            }
            else if (Programmer == subordinate)
            {
                Customer.Notify(msg);
            }

        }
    }

   


}
