using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AdapterConsoleApp
{
    /// <summary>
    /// Интерфейс для работы с Creatio.
    /// </summary>
    interface ICreatio
    {
        /// <summary>
        /// Импортировать объект Creatio.
        /// </summary>
        /// <param name="creatioEntity"> Объект Creatio.</param>
        void ImportCreatioObject(CreatioObject creatioEntity);
    }
}
