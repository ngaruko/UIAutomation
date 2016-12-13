using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vbn.Ui.Framework.PageObjects;

namespace Vbn.Ui.Framework.Settings
{
  public  class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

        public static HomePage HomePage;
        public static LoginPage LogtinPage;
      
    }
}
