using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Norbit.GCRM.Medvedev.AbstractFacrotyConsoleApp
{
    /// <summary>
    /// Фабрика Word.
    /// </summary>
    public class WordFactory : AbstractFactory
    {

        public override AbstractDocument CreateDocument(string data)
        {
            return new WordDocument(data);
        }

    }

    #region Классы фабрики Word.

    public class WordDocument : AbstractDocument
    {
        public WordDocument(string data): base(data)
        {
            Name = "Документ Word";
            DocumentType = "Docx";
            CopyAmount = 5;
        }

        /// <summary>
        /// Преобразование данных в docx формат.
        /// </summary>
        /// <param name="data"> Данные.</param>
        /// <returns> Данные в docx формате.</returns>
        public override string ConvertData(string data)
        {
            return data + " в формате docx";
        }
    }

    #endregion
}