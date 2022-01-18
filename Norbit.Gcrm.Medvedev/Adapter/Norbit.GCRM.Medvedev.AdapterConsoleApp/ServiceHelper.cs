using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AdapterConsoleApp
{
    /// <summary>
    /// cthdb
    /// </summary>
    public class ServiceHelper : ICreatio
    {
        /// <summary>
        /// Импортировать объект Creatio.
        /// </summary>
        /// <param name="creatioEntity"></param>
        public void ImportCreatioObject(CreatioObject creatioEntity)
        {
            Console.WriteLine("Запись успешно импортирована.");
        }
    }
}
