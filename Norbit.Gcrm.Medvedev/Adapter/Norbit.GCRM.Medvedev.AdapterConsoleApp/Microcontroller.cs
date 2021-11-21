using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AdapterConsoleApp
{
    /// <summary>
    /// Микроконтроллер.
    /// </summary>
    public class Microcontroller
    {
        private int _power = 0;

        #region Свойства
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Память.
        /// </summary>
        public int Memory { get; set; }

        /// <summary>
        /// Данные.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Питание.
        /// </summary>
        public int Power
        {
            get
            {
                return _power;
            }
            set
            {
                if ((value > 5) || (value < 0))
                {
                    throw new ArgumentException("Слишком высокое напряжение");
                }
            }
        }

        #endregion

        public Microcontroller(int memory, string name)
        {
            Memory = memory;
            Name = name;
        }

        #region Методы

        /// <summary>
        /// Прошивка контроллера.
        /// </summary>
        /// <param name="power"> Питание.</param>
        /// <param name="data"> Данные, которые нужно внести.</param>
        public void Firmware(int power, string data)
        {
            try
            {
                Power = power;
                Data = data;
                Console.WriteLine("Прошивка удалась!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        #endregion
    }
}
