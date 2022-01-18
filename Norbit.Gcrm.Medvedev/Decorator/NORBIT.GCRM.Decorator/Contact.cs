using Norbit.GCRM.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORBIT.GCRM.Decorator
{

    /// <summary>
    /// Контакт.
    /// </summary>
    public class Contact : CreatioBaseEntity
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Телефон.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Почта.
        /// </summary>
        public string Email { get; set; }

        public Contact(Guid id, string name, string surname,
            string phone, string email) : base(id)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Имя: {Name}\n");
            sb.Append($"Фамилия: {Surname}\n");
            sb.Append($"Телефон: {Phone}\n");
            sb.Append($"Email: {Email}\n");

            return base.ToString() + sb.ToString();
        }

        public void Call()
        {
            Console.WriteLine($"Совершен звонок {Surname} {Name} по номеру {Phone}");
        }

        public void SendEmail()
        {
            Console.WriteLine($"Отправлено письмо {Surname} {Name} по адресу {Email}");
        }
    }


}
