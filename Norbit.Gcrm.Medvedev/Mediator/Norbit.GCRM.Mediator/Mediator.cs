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
        /// Отправить данные через посредника.
        /// </summary>
        /// <param name="data"> Данные.</param>
        /// <param name="db"> База данных.</param>
        public abstract void SendInformation(string data, DataBase db);
    }

    /// <summary>
    /// Сервис для работы с Creatio и 1C.
    /// </summary>
    public class ServiceHelper : Mediator
    {
        #region Свойства.
        /// <summary>
        /// Объект базы Creatio.
        /// </summary>
        public DataBase CreatioDb { get; set; }

        /// <summary>
        /// Объект базы 1с.
        /// </summary>
        public DataBase DataBase1c  {get; set;}

        #endregion

        /// <summary>
        /// Отправка данных.
        /// </summary>
        /// <param name="data"> Данные.</param>
        /// <param name="db"> База данных.</param>
        public override void SendInformation(string data, DataBase db)
        {
            if (CreatioDb == db)
            {
                DataBase1c.SendData(data);
            }
            else
            {
                CreatioDb.SendData(data);
            }

        }
    }

   


}
