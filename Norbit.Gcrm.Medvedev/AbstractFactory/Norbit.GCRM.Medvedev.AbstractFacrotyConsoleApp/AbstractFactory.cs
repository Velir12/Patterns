using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Norbit.GCRM.Medvedev.AbstractFacrotyConsoleApp
{
    /// <summary>
    /// Абстрактная фабрика.
    /// </summary>
    public abstract class AbstractFactory
    {

        /// <summary>
        /// Создание документа.
        /// </summary>
        /// <returns> Документ.</returns>
        public abstract AbstractDocument CreateDocument(string data);

    }

    #region Классы связанные с абстрактной фабрикой.

    /// <summary>
    /// Абстрактный документ.
    /// </summary>
    public abstract class AbstractDocument
    {
        #region Свойства.
        /// <summary>
        /// Название документа.
        /// </summary>
        protected string Name { get; set;}

        /// <summary>
        /// Тип документа.
        /// </summary>
        protected string DocumentType { get; set; }

        /// <summary>
        /// Данные  в документе.
        /// </summary>
        protected string Data { get; set; }

        /// <summary>
        /// Количество копий.
        /// </summary>
        protected int CopyAmount { get; set; }

        #endregion

        public AbstractDocument(string data)
        {
            Data = ConvertData(data);
        }

        /// <summary>
        /// Преобразование данных в подходящий формат.
        /// </summary>
        /// <param name="data"> Данные.</param>
        /// <returns> Данные в нужном формате.</returns>
        public abstract string ConvertData(string data);

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Нзавание документов: {Name}\n");
            sb.Append($"Тип документа: {DocumentType}\n");
            sb.Append($"Количество копий документа: {CopyAmount}\n");
            sb.Append($"\nДанные в документе: \n{Data}\n");
            return sb.ToString();
        }

    }

    #endregion
}