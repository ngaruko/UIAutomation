using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vbn.Ui.Framework.BaseClasses;
using Vbn.Ui.Framework.PageObjects;
using Vbn.Ui.Tests.Utilities;


namespace Vbn.Ui.Tests
{
    [TestClass]
    public class InvalidUserLoginTest//:InitializationTests
    {
        public TestContext TestContext { get; set; }



        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            BaseClass.InitWebdriver("firefox");
            LoginPage.GoTo();
        }




        [TestMethod()]
       [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=C:\SVN\Testing\VbnUIAutomation\Vbn.Ui.Tests\TestDataFiles\LoginData.xlsx;", "LoginTestData$", DataAccessMethod.Sequential)]
       [DeploymentItem(@".\TestDataFiles\LoginData.xlsx")]

        public void Invalid_User_Cannot_Login()
        {

            var userName = TestContext.DataRow["InvalidUser"].ToString();
            var password = TestContext.DataRow["InvalidPassword"].ToString();
            LoginPage.LoginAs(userName).WithPassword(password).Login();

            Console.WriteLine("Attempting to login as " + userName + " using password: " + password);
            LoginPage.ClearInputs();
            Assert.IsFalse(HomePage.IsAt, "Invalid user still logs in?");

        }


        [TestCleanup()]
        public void Cleanup()
        {
            Console.WriteLine("Test Method Cleanup");

        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            Console.WriteLine("Class Cleanup");
        }
    }
}

