using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new AmericanPizza());
            Console.WriteLine(new ItalianPizza());

            Console.WriteLine(new MushroomPizza(new ItalianPizza()));
            Console.WriteLine(new MushroomPizza(new AmericanPizza()));
        }
    }

}
