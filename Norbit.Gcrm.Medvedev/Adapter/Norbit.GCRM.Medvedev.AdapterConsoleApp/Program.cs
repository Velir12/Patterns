using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AdapterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Generator();
            var contoller = new Microcontroller(2048, "STM32");

            contoller.Firmware(generator.Run(), "Код");
        }
    }
}
