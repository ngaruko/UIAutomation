using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vbn.Ui.Framework.BaseClasses;
using Vbn.Ui.Framework.Configuration;
using Vbn.Ui.Framework.PageObjects;

namespace Vbn.Ui.Tests.SmokeTests
{
    [TestClass]
  public  class AWSTest
    {

        [TestMethod()]
        public void LetsTestEC2()
        {
            string username = new AppConfigReader().GetUsername();
            string password = new AppConfigReader().GetPassword();


            //Console.WriteLine("Initialising Assembly: " + context.TestName);
         // new  SauceLabsBase().InitWebdriver();
            LoginPage.GoTo();
            LoginPage.LoginAs(username).WithPassword(password).Login();


            Assert.IsTrue(HomePage.IsAt, "Failed to login.");

        }
    }
}
