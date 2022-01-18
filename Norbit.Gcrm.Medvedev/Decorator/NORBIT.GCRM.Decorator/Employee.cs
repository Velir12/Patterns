using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORBIT.GCRM.Decorator
{
    /// <summary>
    /// Сотрудник.
    /// </summary>
    public class Employee: Contact
    {
        /// <summary>
        /// Должность.
        /// </summary>
        public string Position { get; set; }

        public Employee(Contact contact, string position): 
                base(contact.Id, contact.Name, contact.Surname,
                    contact.Phone, contact.Email)
        {
            Position = position;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"Должность: {Position}\n");

            return base.ToString() + sb.ToString();
        }
    }
}
