using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Vbn.Ui.Framework.BaseClasses;
using Vbn.Ui.Framework.ComponentHelper;
using Vbn.Ui.Framework.Settings;

namespace Vbn.Ui.Framework.PageObjects
{
    public class LoginPage : PageBase
    {


        private IWebDriver driver;


        #region WebElement




        #endregion

        public LoginPage(IWebDriver _driver)
            : base(_driver)
        {
            this.driver = _driver;

        }

        #region Actions

        public static void GoTo()
        {
            //NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            NavigationHelper.NavigateToUrl(ConfigurationManager.AppSettings.Get("BaseAddress"));
           // var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
           // wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "btnLogin");
        }


        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
        #endregion

        public static bool InvalidUser
        {
            get
            {

                return GenericHelper.IsElemetPresent(By.LinkText("User Not Found"));

            }
        }

        public static void ClearInputs()
        {
            GenericHelper.GetElement(By.Id("Username")).Clear();

            GenericHelper.GetElement(By.Id("Password")).Clear();


        }
    }


    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        [FindsBy(How = How.Id, Using = "Username")]
        private static IWebElement UsernameTextBox;

        [FindsBy(How = How.Id, Using = "Password")]
        private static IWebElement PasswordTextBox;

        [FindsBy(How = How.Id, Using = "btnLogin")]
        [CacheLookup]
        private static IWebElement LoginButton;

        [FindsBy(How = How.LinkText, Using = "Vigil Admin Portal")]
        private IWebElement HomeLink;




        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            //UsernameTextBox.SendKeys(userName);
            //PasswordTextBox.SendKeys(password);
            //LoginButton.Click();

            var loginInput = GenericHelper.GetElement(By.Id("Username"));
            loginInput.SendKeys(userName);

            var passwordInput = GenericHelper.GetElement(By.Id("Password"));
            passwordInput.SendKeys(password);

            var loginButton = GenericHelper.GetElement(By.Id("btnLogin"));
            loginButton.Click();

            // GenericHelper.WaitForWebElementInPage(By.LinkText("Vigil Admin Portal"), TimeSpan.FromSeconds(30));
        }





    }




}
