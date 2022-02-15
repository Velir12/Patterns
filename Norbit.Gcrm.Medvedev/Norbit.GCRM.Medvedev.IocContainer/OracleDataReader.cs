using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.IocContainer
{
    /// <summary>
    /// Считыватель данных из Oracle.
    /// </summary>
    public class OracleDataReader: IDataBaseReader
    {
        /// <summary>
        /// Получение данных из БД.
        /// </summary>
        /// <returns> Данные в виде строки.</returns>
        public string GetData()
        {
            return "Данный Oracle";
        }
    }
}
