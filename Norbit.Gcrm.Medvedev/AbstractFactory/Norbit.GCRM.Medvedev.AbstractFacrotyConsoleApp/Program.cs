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
            var client = new Client(new AppleFactory());
            Console.WriteLine(client);

            client = new Client(new SamsungFactory());
            Console.WriteLine(client);

        }
    }
}
