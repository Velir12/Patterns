using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Mediator
{

    /// <summary>
    /// Подчиненный.
    /// </summary>
    public abstract class Subordinate
    {
        #region Свойства

        /// <summary>
        /// Медиатор.
        /// </summary>
        protected Mediator mediator;

        /// <summary>
        /// Должность.
        /// </summary>
        protected string Post { get; set; }

        #endregion

        public Subordinate(Mediator mediator)
        {
            this.mediator = mediator;
        }

        #region Методы

        /// <summary>
        /// Отпрака сообщения через посредника.
        /// </summary>
        /// <param name="message"> Текст сообщение.</param>
        public virtual void SendMessage(string message)
        {
            mediator.SendInformation(message, this);
        }

        /// <summary>
        /// Уведомлять о статусе задачи.
        /// </summary>
        /// <param name="task"> Текст задачи.</param>
        public abstract void Notify(string task);

        #endregion
    }

    /// <summary>
    /// Заказчик.
    /// </summary>
    public class Сustomer : Subordinate
    {
        public Сustomer(Mediator mediator) : base(mediator)
        {
            Post = "Заказчик";
        }

        /// <summary>
        /// Уведомление о статусе задачи.
        /// </summary>
        /// <param name="task"> Задача.</param>
        public override void Notify(string task)
        {
            Console.WriteLine($"{Post} принял задачу: {task}");
        }
    }

    /// <summary>
    /// Программист.
    /// </summary>
    public class Programer : Subordinate
    {
        public Programer(Mediator mediator) : base(mediator)
        {
            Post = "Программист";
        }

        /// <summary>
        /// Уведомление о статусе задачи.
        /// </summary>
        /// <param name="task"> Задача.</param>
        public override void Notify(string task)
        {
            Console.WriteLine($"{Post} выполняет задачу: {task}");
        }
    }

    /// <summary>
    /// Аналитик.
    /// </summary>
    public class Analyst : Subordinate
    {
        public Analyst(Mediator mediator) : base(mediator)
        {
            Post = "Аналитик";
        }

        /// <summary>
        /// Уведомление о статусе задачи.
        /// </summary>
        /// <param name="task"> Задача.</param>
        public override void Notify(string task)
        {
            Console.WriteLine($"{Post} оценивает задачу: {task}");
        }
    }

}
