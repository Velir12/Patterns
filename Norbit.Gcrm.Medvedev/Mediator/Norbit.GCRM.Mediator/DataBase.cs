using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Mediator
{

    /// <summary>
    /// База данных.
    /// </summary>
    public abstract class DataBase
    {
        #region Свойства

        /// <summary>
        /// Медиатор.
        /// </summary>
        protected Mediator mediator;

        /// <summary>
        /// Название базы данных.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Тип базы данных.
        /// </summary>
        public string Type { get; set; }

        #endregion

        public DataBase(Mediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Получить данные.
        /// </summary>
        /// <param name="data"> Данные.</param>
        public virtual void GetData(string data)
        {
            mediator.SendInformation(data, this);
        }

        /// <summary>
        /// Отправить данные.
        /// </summary>
        /// <param name="data"></param>
        public abstract void SendData(string data);
    }

    /// <summary>
    /// База данных Creatio.
    /// </summary>
    public class CreatioDataBase: DataBase
    {
        public CreatioDataBase(Mediator mediator): base(mediator)
        {
            Title = "База данных Creatio";
            Type = "PostgreSql";
        }

        /// <summary>
        /// Получить данные.
        /// </summary>
        /// <param name="data"> Данные.</param>
        public override void SendData(string data)
        {
            Console.WriteLine($"Система {Title} с типом {Type} отправила в 1с данные: {data}");
        }
    }

    /// <summary>
    /// База данных 1с, из которой приходят данные.
    /// </summary>
    public class DataBase1c : DataBase
    {
        public DataBase1c(Mediator mediator): base(mediator)
        {
            Title = "База данных 1c заказчика";
            Type = "1C";
        }

        /// <summary>
        /// Отправка данных в Creatio.
        /// </summary>
        /// <param name="data"> Данные.</param>
        public override void SendData(string data)
        {
            Console.WriteLine($"Система {Title} с типом {Type} отправила в Creatio данные: {data}");
        }
    }

}
