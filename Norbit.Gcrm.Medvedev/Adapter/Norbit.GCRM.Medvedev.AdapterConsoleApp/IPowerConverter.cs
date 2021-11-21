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
    public interface IPowerConverter
    {
        /// <summary>
        /// Преобразование напряжения к корректному.
        /// </summary>
        /// <param name="power"> Входное напряжение.</param>
        /// <returns> Скорретированное напряжение.</returns>
        int ConvertPower(int power);
    }
}
