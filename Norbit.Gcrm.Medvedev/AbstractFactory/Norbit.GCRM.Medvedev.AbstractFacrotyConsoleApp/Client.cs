using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AbstractFacrotyConsoleApp
{
    /// <summary>
    /// Клиент, определяющий какой продукт надо создать.
    /// </summary>
    public class Client
    {
        #region Свойства

        /// <summary>
        /// Телефон.
        /// </summary>
        public AbstractDocument document;

        #endregion

        /// <summary>
        /// Конструктор, создающий продукты.
        /// </summary>
        /// <param name="factory"> Фабрика, которая будет использоваться для создания.</param>
        public Client(AbstractFactory factory)
        {
            document = factory.CreateDocument("Данные");
        }

        /// <summary>
        /// Приведение информации о продуктах в строку.
        /// </summary>
        /// <returns> Информацию о продуктах.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Информация о документе:\n");
            sb.Append(document);
            return sb.ToString();
        }
    }
}
