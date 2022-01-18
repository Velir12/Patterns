using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AdapterConsoleApp
{
    /// <summary>
    /// Адаптер.
    /// </summary>
    public class Adapter
    {
        /// <summary>
        /// Преобразование объекта 1с к Creatio.
        /// </summary>
        /// <param name="object1c"> Объект 1с</param>
        /// <returns> Объект Creatio.</returns>
        public CreatioObject ConvertToCreatioObject(Object1c object1c)
        {
            return new CreatioObject(Guid.NewGuid(), object1c.Name, object1c.Id);
        }
    }
}
