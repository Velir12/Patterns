using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Norbit.GCRM.Medvedev.AbstractFacrotyConsoleApp
{
    /// <summary>
    /// Фабрика Apple.
    /// </summary>
    public class ExcelFactory : AbstractFactory
    {
      
        /// <summary>
        /// Создание Excel документа.
        /// </summary>
        /// <returns> Документ Excel.</returns>
        public override AbstractDocument CreateDocument(string data)
        {
            return new ExcelDocument(data);
        }
    }

    #region Классы фабрики Document.

    public class ExcelDocument: AbstractDocument
    {
        public ExcelDocument(string data): base(data)
        {
            Name = "Документ Excel";
            DocumentType = "Excel";
            CopyAmount = 10;
        }

        /// <summary>
        /// Преобразование данных в Excel формат..
        /// </summary>
        /// <param name="data"> Данные.</param>
        /// <returns> Данные в Excel формате.</returns>
        public override string ConvertData(string data)
        {
            //TODO: Реализовать преобразование данных в Excel формат.
            return data + " в формате Excel";

        }
    }

    #endregion


}