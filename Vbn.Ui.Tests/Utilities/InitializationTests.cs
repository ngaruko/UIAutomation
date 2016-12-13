using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vbn.Ui.Framework;
using Vbn.Ui.Framework.BaseClasses;
using Vbn.Ui.Framework.ComponentHelper;
using Vbn.Ui.Framework.Configuration;
using Vbn.Ui.Framework.PageObjects;
using Vbn.Ui.Framework.Settings;

namespace Vbn.Ui.Tests
{
  
    public class InitializationTests
    {

        private TestContext _testContext;

        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }



        [TestInitialize()]
       // [TestMethod()]
        [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=C:\SVN\Testing\VbnUIAutomation\Vbn.Ui.Tests\TestDataFiles\LoginData.xlsx;", "Capabilities$", DataAccessMethod.Sequential)]
        [DeploymentItem(@".\TestDataFiles\LoginData.xlsx")]
        public  void AssemblyInit()
        {
            string username = new AppConfigReader().GetUsername();
            string password = new AppConfigReader().GetPassword();
            Console.WriteLine("Initialising tests: ");
            string browser = "firefox";
           //string browser =  TestContext.DataRow["Browser"].ToString();
            BaseClass.InitWebdriver(browser);
           
            LoginPage.GoTo();
          LoginPage.LoginAs(username).WithPassword(password).Login();
        }

        [TestMethod]
        public void DriverHasBeenInitialised()
        {
            Assert.AreEqual("a","a");
        }


      [TestCleanup()]
        public  void AssemblyCleanup()
        {
            Console.WriteLine("Assembly Cleanup");

            BaseClass.TearDown();
        }


    }
}
