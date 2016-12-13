using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Vbn.Ui.Framework.ComponentHelper;

namespace Vbn.Ui.Framework.BaseClasses
{
    public class PageBase
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "Vigil Admin Portal")]
        private IWebElement HomeLink;

        public PageBase(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            this.driver = _driver;
        }

        public void Logout()
        {
            if (GenericHelper.IsElemetPresent(By.ClassName("profile-info")))
            {
                ButtonHelper.ClickButton(By.ClassName("profile-info"));
                ButtonHelper.ClickButton(By.LinkText("Logout"));
            }
            GenericHelper.WaitForWebElementInPage(By.Id("btnLogin"), TimeSpan.FromSeconds(30));

        }

        protected void NaviGateToHomePage()
        {
            HomeLink.Click();
        }

        public string Title
        {
            get { return driver.Title; }
        }

        public static bool IsAt
        {
             get 
            { 
               
              return  GenericHelper.IsElemetPresent(By.LinkText("Vigil Admin Portal"));
             
            }
            
        }
    }
}
