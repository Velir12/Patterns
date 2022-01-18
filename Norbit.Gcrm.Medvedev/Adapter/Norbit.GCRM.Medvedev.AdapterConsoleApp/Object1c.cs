using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AdapterConsoleApp
{
    /// <summary>
    /// Объект 1с.
    /// </summary>
    public class Object1c
    {
        /// <summary>
        /// Идентификатор объекта.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название объекта.
        /// </summary>
        public string Name { get; set; }

        public Object1c(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
