using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using Vbn.Ui.Framework.Settings;
using Vbn.Ui.Framework.CustomExceptions;
using Vbn.Ui.Framework.ComponentHelper;
using NUnit.Framework;
using Vbn.Ui.Framework.Configuration;

namespace Vbn.Ui.Framework.BaseClasses
{

    //[TestClass]    
    // [DeploymentItem(@"Resources", "Resources")]
    public class BaseClass
    {

        private static FirefoxProfile GetFirefoxptions()
        {
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxProfileManager manager = new FirefoxProfileManager();
            //profile = manager.GetProfile("default");
            return profile;
        }
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");

            return option;
        }

        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            options.ElementScrollBehavior = InternetExplorerElementScrollBehavior.Bottom;
            return options;
        }



        private static PhantomJSOptions GetPhantomJsptions()
        {
            PhantomJSOptions option = new PhantomJSOptions();
            option.AddAdditionalCapability("handlesAlerts", true);
            return option;
        }

      



        private static RemoteWebDriver GetRemoteDriver(string browser)
        {
            DesiredCapabilities capabilities=new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName,browser);
            return new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities, TimeSpan.FromSeconds(600));
        }


        // [AssemblyInitialize]
        //[BeforeFeature()]
        public static void InitWebdriver( string browser)
        {
            ObjectRepository.Config = new AppConfigReader();

     DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, browser);
            ObjectRepository.Driver=new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities, TimeSpan.FromSeconds(600));
            
            BrowserHelper.BrowserMaximize();

        }

        private static IWebDriver GetDriver(string browser)
        { 
            //string driverPath;
            switch (browser)
            {
                case "Firefox":
                 ObjectRepository.Driver = new FirefoxDriver();
                   
                    break;

                case "Chrome":
                   var driverPath= @"C:\SVN\Testing\VbnUIAutomation\packages\Selenium.WebDriver.ChromeDriver.2.21.0.0\driver";
           
                    ObjectRepository.Driver =  new ChromeDriver(driverPath);
                   

                    break;

                case "IE":
                    ObjectRepository.Driver = new InternetExplorerDriver();
                    break;

                case "PhantomJs":

                    ObjectRepository.Driver = new PhantomJSDriver();
                    break;

                default:
                    throw new NoSuitableBrowserFoundException("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());
            }


            return ObjectRepository.Driver;
        }


        // [AssemblyCleanup]
        //[AfterScenario()]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
