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
            var userConnection = UserConnection.GetUserConnection(false, true);

            var newUserConnection = UserConnection.GetUserConnection(true, true);

            if (userConnection == newUserConnection)
            {
                Console.WriteLine("То же самое подключение");
            }
            else
            {
                Console.WriteLine("Разные подключения");
            }
        }
    }

}
