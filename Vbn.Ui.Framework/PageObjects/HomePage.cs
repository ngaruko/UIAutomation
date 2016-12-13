using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Vbn.Ui.Framework.BaseClasses;
using Vbn.Ui.Framework.ComponentHelper;

namespace Vbn.Ui.Framework.PageObjects
{
    public  class HomePage : PageBase
    {

        
        private IWebDriver driver;
        #region WebElement

        [FindsBy(How = How.CssSelector, Using ="input[type='search']")]
        private static IWebElement QuickSearchTextBox;

        

        [FindsBy(How = How.ClassName, Using = "fa fa-search")]
        [CacheLookup]
        private static IWebElement QuickSearchBtn;

        //[FindsBy(How = How.LinkText, Using = "File a Bug")]
        //private IWebElement FileABugLink;

        #endregion


        public HomePage(IWebDriver _driver)

            : base(_driver)
        {

            this.driver = _driver;
        }

        #region Actions

        public HomePage(IWebDriver _driver, IWebDriver driver, IWebElement quickSearchTextBox, IWebElement quickSearchBtn) : base(_driver)
        {
            this.driver = driver;
            QuickSearchTextBox = quickSearchTextBox;
            QuickSearchBtn = quickSearchBtn;
        }

        public static  void QuickSearch(string text)
        {
            IWebElement seachBox = GenericHelper.GetElement(By.CssSelector("input[type='search']"));
         
           // QuickSearchTextBox.
           seachBox.SendKeys(text);
           GenericHelper.GetElement(By.XPath(".//*[@id='mapDataTable_filter']/label/i")).Click();
           // QuickSearchBtn.Click();
        }

        #endregion

        #region Navigation

        //public LoginPage NavigateToLogin()
        //{
        //    FileABugLink.Click();
        //    GenericHelper.WaitForWebElementInPage(By.Id("log_in"), TimeSpan.FromSeconds(30));
        //    return new LoginPage(driver);
        //}

        #endregion
    }
}