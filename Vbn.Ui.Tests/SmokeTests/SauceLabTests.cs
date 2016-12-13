using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vbn.Ui.Framework.BaseClasses;
using Vbn.Ui.Framework.Configuration;
using Vbn.Ui.Framework.PageObjects;
using Vbn.Ui.Tests.Utilities;

namespace Vbn.Ui.Tests.SmokeTests
{
    [TestClass]
    public class SauceLabTests 
    {

        //COMMENT OUT INITIALISATION ASSEMBLY


        [TestMethod()]
        public void LetsTestCloud()
        {
            string username = new AppConfigReader().GetUsername();
            string password = new AppConfigReader().GetPassword();

            List<string> browsers=new List<string>(){"firefox", "chome", "internet explorer"};
            string browser="firefox";
            new SauceLabsBase("chrome").InitWebdriver();
            LoginPage.GoTo();
            LoginPage.LoginAs(username).WithPassword(password).Login();


            Assert.IsTrue(HomePage.IsAt, "Failed to login.");

        }


    }
}
