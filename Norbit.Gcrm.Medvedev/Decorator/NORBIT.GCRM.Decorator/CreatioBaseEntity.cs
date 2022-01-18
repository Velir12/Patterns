using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Decorator
{
    /// <summary>
    /// Базовый объект Creatio.
    /// </summary>
    public abstract class CreatioBaseEntity
    {
        /// <summary>
        /// Уникальный идентификатор объекта.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Дата создания объекта.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Дата изменения объекта.
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        public CreatioBaseEntity(Guid id)
        {
            Id = id;
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"Идентификатор: {Id}\n");
            sb.Append($"Дата создания: {CreatedOn}\n");
            sb.Append($"Идентификатор: {ModifiedOn}\n");

            return sb.ToString();
        }
    }

}
