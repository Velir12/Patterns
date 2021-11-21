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
            Manager mediator = new Manager();

            Subordinate customer = new Сustomer(mediator);
            Subordinate programmer = new Programer(mediator);
            Subordinate analyst = new Analyst(mediator);

            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Analyst = analyst;

            customer.SendMessage("Нужна интеграция с телефонией");
            analyst.SendMessage("Нужен коннектор и сервис для телефонии");
            programmer.SendMessage("Сервис и коннектор готовы.");


        }
    }
}
