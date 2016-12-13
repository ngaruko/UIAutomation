using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vbn.Ui.Framework.BaseClasses;
using Vbn.Ui.Framework.PageObjects;

namespace Vbn.Ui.Tests.SmokeTests
{
  
    [TestClass]
    
    public  class CrossBrowserTest
    {
        public TestContext TestContext { get; set; }

        

        [TestMethod()]
       [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=C:\SVN\Testing\VbnUIAutomation\Vbn.Ui.Tests\TestDataFiles\LoginData.xlsx;", "LoginTestData$", DataAccessMethod.Sequential)]
       [DeploymentItem(@".\TestDataFiles\LoginData.xlsx")]

        public void CanOpenMultipleBrowsers()
        {
          
             var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            if (directoryInfo != null)
                Console.WriteLine(directoryInfo.FullName);
            var browser = TestContext.DataRow["Browser"].ToString();
            Console.WriteLine(browser);

            Driver.Initialize(browser);


            LoginPage.GoTo();

            LoginPage.LoginAs("testing").WithPassword("testing").Login();
        }

        [TestCleanup()]
        public void AssemblyCleanup()
        {
            Console.WriteLine("test Cleanup");

           // Driver.Close();
        }

    }
}
