using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vbn.Ui.Framework.Settings;
using Vbn.Ui.Framework.BaseClasses;
using Vbn.Ui.Framework.ComponentHelper;
using Vbn.Ui.Framework.PageObjects;

namespace Vbn.Ui.Tests.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            //BaseClass.InitWebdriver();
            // page = ObjectRepository.Driver.Navigate();
            Console.WriteLine("Testing");
            Console.WriteLine( ObjectRepository.Config.GetWebsite());
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //  Console.WriteLine("Title of Page : {0}", WindowHelper.GetTitle());
            LoginPage.LoginAs("robert").WithPassword("rshin").Login();
            
            
            //BaseClass.TearDown();
        }
    }
}
