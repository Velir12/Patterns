using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.IocContainer
{
    /// <summary>
    /// Интерфейс для внедрения зависимостей.
    /// </summary>
    public interface IDataBaseReader
    {
        /// <summary>
        /// Получение данных из БД.
        /// </summary>
        /// <returns> Данные в виде строки.</returns>
        string GetData();
    }
}
