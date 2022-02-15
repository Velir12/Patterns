using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightInject;

namespace Norbit.GCRM.Medvedev.IocContainer
{
    /// <summary>
    /// Считыватель данных из Postgre.
    /// </summary>
    class PostgreSqlDataReader: IDataBaseReader
    {
        /// <summary>
        /// Получение данных из БД.
        /// </summary>
        /// <returns> Данные в виде строки.</returns>
        public string GetData()
        {
            return "Данный Postgre";
        }
    }
}
