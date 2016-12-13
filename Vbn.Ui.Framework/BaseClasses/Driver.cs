using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using Vbn.Ui.Framework.ComponentHelper;

namespace Vbn.Ui.Framework.BaseClasses
{
    public class Driver
    {
        public static RemoteWebDriver Instance { get; set; }


        // private static String browser;
        private String version;
        private String os;
        private const string serverUrl= "http://localhost:4444/wd/hub";

        //public Driver(String browser, String version, String os)
        //{
        //    this.browser = browser;
        //    this.version = version;
        //    this.os = os;

        //}


        public static string BaseAddress
        {
            get { return ConfigurationManager.AppSettings.Get("BaseAddress"); }
        }

        public static void Initialize(string browser)
        {
            
            
            

            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability(CapabilityType.BrowserName, browser);
            // caps.SetCapability(CapabilityType.Version, version);
            //caps.SetCapability(CapabilityType.Platform, os);
        

            Instance=(browser == "internet explorer")? GetIERemoteDriver():new RemoteWebDriver(new Uri(serverUrl), caps, TimeSpan.FromSeconds(600));
            
           BrowserHelper.BrowserMaximize();
            // TurnOnWait();
        }

        private static RemoteWebDriver GetIERemoteDriver()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            options.ElementScrollBehavior = InternetExplorerElementScrollBehavior.Bottom;

           return new RemoteWebDriver(new Uri(serverUrl), options.ToCapabilities(), TimeSpan.FromSeconds(600));
        }


        public static void Close()
        {
            Instance.Close();
        }

        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }

        public static void NoWait(Action action)
        {
            TurnOffWait();
            action();
            TurnOnWait();
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        private static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
        }
    }
}