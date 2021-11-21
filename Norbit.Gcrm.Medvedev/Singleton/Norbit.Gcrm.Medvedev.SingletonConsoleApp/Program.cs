using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.Gcrm.Medvedev.SingletonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myComputer = Computer.GetComputer("Windows", 2048, "Intel Core i5");
            Console.WriteLine(myComputer);
            var newComputer = Computer.GetComputer("Windows", 4096, "Intel Core i9");
            Console.WriteLine(newComputer);

            if (myComputer == newComputer)
            {
                Console.WriteLine("Один и тот же компьютер");
            }
            else
            {
                Console.WriteLine("Разные компьтеры");
            }
        }
    }

}
