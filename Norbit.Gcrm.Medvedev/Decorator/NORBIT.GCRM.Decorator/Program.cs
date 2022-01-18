using NORBIT.GCRM.Decorator;
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
            var contact = new Contact(Guid.NewGuid(), "Иван", "Медведев", "+79123365895", "elurezvelir2017@gmail.com");
            var employee = new Employee(contact, "Продавец мебели");

            contact = new Contact(Guid.NewGuid(), "Данил", "Абунин", "+78005553535", "mom@mail.ru");
            var client = new Client(contact, "Мебель");

            var price = 10000;
            var status = "В процессе";
            var order = new Order(Guid.NewGuid(), price, status, client, employee);

            var info = order.GetOrderInfo();

            Console.WriteLine(info);
        }
    }

}
