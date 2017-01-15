

namespace CreateExcelProcess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MS.Common.ExcelHelper;

    class Program
    {
        static void Main(string[] args)
        {

            ExcelHelper.CreateInstance().CreateExcel<string>(null,null);

        }
    }
}
