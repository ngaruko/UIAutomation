using System;
using System.Runtime.CompilerServices;
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
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;

namespace Vbn.Ui.Framework.BaseClasses
{

    public class SauceLabsBase
    {
       private IWebDriver driver;
        private String browser;
        
       

        public SauceLabsBase(String browser)
        {
            this.browser = browser;
        }

       
        
        public  void InitWebdriver()
        {
            

            ObjectRepository.Config = new AppConfigReader();



            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;

                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.IE:
                    ObjectRepository.Driver = GetIEDriver();
                    break;

                case BrowserType.PhantomJs:
                    ObjectRepository.Driver = GetPhantomJsDriver();
                    break;

                default:
                    throw new NoSuitableBrowserFoundException("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());
            }


          //  DesiredCapabilities capabilities = new DesiredCapabilities();
          //capabilities.SetCapability(CapabilityType.BrowserName, browser);

           

          //  ObjectRepository.Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities, TimeSpan.FromSeconds(600));
          //  BrowserHelper.BrowserMaximize();




            //ObjectRepository.Driver.Manage()
            //    .Timeouts()
            //    .SetPageLoadTimeout(TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut()));
            //ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            BrowserHelper.BrowserMaximize();
            

        }

        #region browsers
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


        private static FirefoxDriver GetFirefoxDriver()
        {
            FirefoxDriver driver = new FirefoxDriver(GetFirefoxptions());
            return driver;
        }

        private static ChromeDriver GetChromeDriver()
        {
            ChromeDriver driver = new ChromeDriver(@"C:\SVN\Testing\VbnUIAutomation\Vbn.Ui.Framework\chromedriver", GetChromeOptions());
            return driver;
        }

        private static InternetExplorerDriver GetIEDriver()
        {
            InternetExplorerDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        private static PhantomJSDriver GetPhantomJsDriver()
        {
            PhantomJSDriver driver = new PhantomJSDriver(GetPhantomJsptions());

            return driver;
        }

        private static PhantomJSOptions GetPhantomJsptions()
        {
            PhantomJSOptions option = new PhantomJSOptions();
            option.AddAdditionalCapability("handlesAlerts", true);
            return option;
        }

        private static PhantomJSDriverService GetPhantomJsDrvierService()
        {
            PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();
            service.LogFile = "TestPhantomJS.log";
            service.HideCommandPromptWindow = false;
            service.LoadImages = true;
            return service;

            
        }  
       
        
        #endregion
    }

 
  

}
