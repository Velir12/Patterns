using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceHelper();

            var db1c = new DataBase1c(service);
            var creatio = new CreatioDataBase(service);

            service.DataBase1c = db1c;
            service.CreatioDb = creatio;

            db1c.GetData("Данные из Creatio");

            creatio.GetData("Данные из 1С");
        }
    }
}
