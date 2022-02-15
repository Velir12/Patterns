using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.IocContainer
{
    /// <summary>
    /// Дисплей для отображения данных.
    /// </summary>
    public class Display
    {
        private IDataBaseReader _reader;

        public Display(IDataBaseReader reader)
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
