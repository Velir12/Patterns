using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.Gcrm.Medvedev.SingletonConsoleApp
{

    /// <summary>
    /// Компьютер.
    /// </summary>
    public class Computer
    {

        private static Computer _computer = null;

        #region Свойства

        /// <summary>
        /// Память компьютера.
        /// </summary>
        public int Memory { get; set; }

        /// <summary>
        /// Тип ОС.
        /// </summary>
        public string OSType { get; set; }

        /// <summary>
        /// Процессор.
        /// </summary>
        public string CPU { get; set; }

        #endregion

        /// <summary>
        /// Закрытый конструктор.
        /// </summary>
        /// <param name="type"> Тип ОС.</param>
        /// <param name="memory"> Память компьютера.</param>
        /// <param name="cpu"> Процессор.</param>
        private Computer(string type, int memory, string cpu)
        {
            Memory = memory;
            OSType = type;
            CPU = cpu;
        }

        /// <summary>
        /// Получение объекта компьютера.
        /// </summary>
        /// <param name="type"> Тип ОС.</param>
        /// <param name="memory"> Память компьютера.</param>
        /// <param name="cpu"> Процессор.</param>
        /// <returns> Объект компьютера.</returns>
        public static Computer GetComputer(string type, int memory, string cpu)
        {
            if (_computer == null)
            {
                _computer = new Computer(type, memory, cpu);
            }
            else
            {
                _computer.CPU = cpu;
                _computer.Memory = memory;
                _computer.OSType = type;
            }

            return _computer;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Тип операционной системы: {OSType}\n");
            sb.Append($"Память в Мбайтах: {Memory}\n");
            sb.Append($"Процессор: {CPU}\n");
            return sb.ToString();
        }
    }
}
