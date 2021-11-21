using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.IocAndDi
{
    /// <summary>
    /// Дисплей для отображения данных.
    /// </summary>
    public class Dispaly
    {
        private IDataBaseReader _reader;

        public Dispaly(IDataBaseReader reader)
        {
            _reader = reader;
        }

        /// <summary>
        /// Получить данные из базы данных.
        /// </summary>
        /// <returns></returns>
        public string GetDataBaseData()
        {
            return _reader.GetData();
        }
    }
}
