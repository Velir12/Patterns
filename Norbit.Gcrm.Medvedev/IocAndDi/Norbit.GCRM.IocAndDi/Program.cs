using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.IocAndDi
{
    class Program
    {
        static void Main(string[] args)
        {
            var postgre = new PostgreSqlDBReader();
            var oracle = new OracleDbReader();
            var msSql = new MsSqlDBReader();

            Console.WriteLine(new Display(postgre).GetDataBaseData());
            Console.WriteLine(new Display(oracle).GetDataBaseData());
            Console.WriteLine(new Display(msSql).GetDataBaseData());
        }
    }
}
