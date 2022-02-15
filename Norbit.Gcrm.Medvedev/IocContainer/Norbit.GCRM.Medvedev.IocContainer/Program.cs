using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightInject;

namespace Norbit.GCRM.Medvedev.IocContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new ServiceContainer();
            container.Register<IDataBaseReader, MsSqlDataReader>("MsSql");
            container.Register<IDataBaseReader, OracleDataReader>("Oracle");
            container.Register<IDataBaseReader, PostgreSqlDataReader>("PostgreSql");
            var dataReaders = container.GetAllInstances<IDataBaseReader>();
            foreach (var dataReader in dataReaders)
            {
                Console.WriteLine(new Display(dataReader).GetDataBaseData());
            }

        }
    }
}
