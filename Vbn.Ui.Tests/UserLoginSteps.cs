using System;
using TechTalk.SpecFlow;
using Vbn.Ui.Framework.PageObjects;

namespace Vbn.Ui.Tests
{
    [Binding]
    public class UserLoginSteps
    {
        [Given(@"I have browsed to the VBN Admin Portal")]
        public void GivenIHaveBrowsedToTheVBNAdminPortal()
        {
           // HomePage.goto()
            //;
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered my user name")]
        public void GivenIHaveEnteredMyUserName()
        {
            LoginPage.LoginAs("r").WithPassword("").Login();
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered an invalid user name")]
        public void GivenIHaveEnteredAnInvalidUserName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not entered any user name")]
        public void GivenIHaveNotEnteredAnyUserName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have not entered any password")]
        public void GivenIHaveNotEnteredAnyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter a good password")]
        public void WhenIEnterAGoodPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter any password")]
        public void WhenIEnterAnyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter a bad password")]
        public void WhenIEnterABadPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the VBN should display the Vigil Admin Portal")]
        public void ThenTheVBNShouldDisplayTheVigilAdminPortal()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the VBN should reject the username")]
        public void ThenTheVBNShouldRejectTheUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the VBN should reject the password")]
        public void ThenTheVBNShouldRejectThePassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the error message ""(.*)"" is displayed")]
        public void ThenTheErrorMessageIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the error message ""(.*)"" is displaye")]
        public void ThenTheErrorMessageIsDisplaye(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
