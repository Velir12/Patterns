using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORBIT.GCRM.Decorator
{
    /// <summary>
    /// Клиент.
    /// </summary>
    public class Client : Contact
    {
        /// <summary>
        /// Товарное направление.
        /// </summary>
        public string Direction { get; set; }

        public Client(Contact contact, string direction): 
                base(contact.Id, contact.Name, contact.Surname,
                    contact.Phone, contact.Email)
        {
            Direction = direction;
        }

        public override string ToString()
        {
            return base.ToString() + $"Товарное направление: {Direction}\n";
        }
    }
}
