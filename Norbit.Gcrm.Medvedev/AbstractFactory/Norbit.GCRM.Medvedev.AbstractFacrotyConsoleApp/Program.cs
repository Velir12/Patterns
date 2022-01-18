using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AbstractFacrotyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new ExcelFactory());
            Console.WriteLine(client);

            client = new Client(new WordFactory());
            Console.WriteLine(client);

        }
    }
}
