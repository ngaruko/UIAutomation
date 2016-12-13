using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vbn.Ui.Framework.BaseClasses;
using Vbn.Ui.Framework.Configuration;
using Vbn.Ui.Framework.PageObjects;
using Vbn.Ui.Framework.Settings;
using Vbn.Ui.Tests;
using Vbn.Ui.Tests.Utilities;


namespace Vbn.Ui.Tests.SmokeTests
{
    [TestClass]
    public class LoginTests:InitializationTests
    {

      
        [TestMethod()]
        public void Admin_User_Can_Login()
        {
         Assert.IsTrue(HomePage.IsAt, "Failed to login.");

            Console.WriteLine("testing login");

        }

   
    }
}
