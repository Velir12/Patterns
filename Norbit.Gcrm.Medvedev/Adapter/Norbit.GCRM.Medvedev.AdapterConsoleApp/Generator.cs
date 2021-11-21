using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AdapterConsoleApp
{
    /// <summary>
    /// Генератор.
    /// </summary>
    public class Generator: IPowerConverter
    {
        private const int Power = 220;

        #region Методы.

        /// <summary>
        /// Преобразователь мощности.
        /// </summary>
        /// <param name="power"> Питание.</param>
        /// <returns> Сбалансированную мощность.</returns>
        public int ConvertPower(int power)
        {
            return power / 44;
        }

        /// <summary>
        /// Запуск генератора.
        /// </summary>
        /// <returns> Напряжение генератора.</returns>
        public int Run()
        {
            return ConvertPower(Power);
        }

        /// <summary>
        /// Остановка генератора.
        /// </summary>
        /// <returns> Напряжение генератора.</returns>
        public int Stop()
        {
            return 0;
        }

        #endregion
    }
}
