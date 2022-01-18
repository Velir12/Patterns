using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AdapterConsoleApp
{
    /// <summary>
    /// Базовый объект Creatio.
    /// </summary>
    public class CreatioObject
    {
        /// <summary>
        /// Уникальный идентификатор объекта.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Дата создания объекта.
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Дата изменения объекта.
        /// </summary>
        public DateTime ModifiedOn { get; private set; }

        /// <summary>
        /// Идентификатор объекта в другой системе.
        /// </summary>
        public int OtherObjectId { get; private set; }

        /// <summary>
        /// Имя объекта.
        /// </summary>
        public string Name { get; private set; }

        public CreatioObject(Guid id, string name, int otherId)
        {
            Id = id;
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
            Name = name;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"Идентификатор: {Id}\n");
            sb.Append($"Дата создания: {CreatedOn}\n");
            sb.Append($"Дата изменения: {ModifiedOn}\n");
            sb.Append($"Имя объекта: {Name}\n");
            sb.Append($"Идентификатор объекта в другой системе: {OtherObjectId}\n");

            return sb.ToString();
        }
    }
}
