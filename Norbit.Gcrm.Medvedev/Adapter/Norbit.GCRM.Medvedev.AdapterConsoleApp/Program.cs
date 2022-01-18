using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.AdapterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var otherEntity = new Object1c(1, "Объект 1с");

            var serviceHelper = new ServiceHelper();
            var adapter = new Adapter();
            serviceHelper.ImportCreatioObject(adapter.ConvertToCreatioObject(otherEntity));
        }
    }
}
