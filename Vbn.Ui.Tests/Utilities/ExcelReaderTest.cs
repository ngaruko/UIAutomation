using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vbn.Ui.Tests.Utilities
{
  


    [TestClass]
    public class TestExcelData
    {
        [TestMethod]
        public void ExcelReaderTest()
        {
            //FileStream stream = new FileStream(@"C:\SVN\Testing\VbnUIAutomation\Vbn.Ui.Tests\TestDataFiles\LoginData.xlsx", FileMode.Open, FileAccess.Read);
            //IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //DataTable table = reader.AsDataSet().Tables["Bugzilla"];
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    var col = table.Rows[i];
            //    for (int j = 0; j < col.ItemArray.Length; j++)
            //    {
            //        Console.Write("Data : {0}", col.ItemArray[j]);
            //    }
            //    Console.WriteLine();
            //}


            string xlPath = @"C:\SVN\Testing\VbnUIAutomation\Vbn.Ui.Tests\TestDataFiles\LoginData.xlsx";
            Console.WriteLine(ExcelReader.GetCellData(xlPath, "LoginTestData", 0, 0));
            Console.WriteLine(ExcelReader.GetCellData(xlPath, "LoginTestData", 0, 1));
            Console.WriteLine(ExcelReader.GetCellData(xlPath, "LoginTestData", 1, 0));
            Console.WriteLine(ExcelReader.GetCellData(xlPath, "LoginTestData", 1, 1));
            //Console.WriteLine(ExcelReader.GetCellData(xlPath, "LoginTestData", 0, 2));


           

        }
    }
}
