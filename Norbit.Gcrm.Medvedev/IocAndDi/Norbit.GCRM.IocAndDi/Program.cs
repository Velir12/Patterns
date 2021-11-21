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

            Console.WriteLine(new Dispaly(postgre).GetDataBaseData());
            Console.WriteLine(new Dispaly(oracle).GetDataBaseData());
            Console.WriteLine(new Dispaly(msSql).GetDataBaseData());
        }
    }
}
