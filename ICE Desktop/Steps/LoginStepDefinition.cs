using BDD_AutomationTests.Behavior;
using BDD_AutomationTests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BDD_AutomationTests.Steps
{
    [Binding]
    public class LoginStepDefinition

    {
        private LoginPage loginPage;  
        private HomePage homePage; 

        public LoginStepDefinition(IWebDriver driver)
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
        }

        [Then(@"Verify home page is dispalyed")]
        public void ThenVerifyhomepageisdispalyed()
        {
            new ValidLoginBehavior(homePage).Perform();
        }

        [Then(@"Verify invalid credential message is displaying")]
        public void ThenVerifyInvalidCredentialMessageIsDisplaying()
        {
           new InvalidLoginBehavior(loginPage).Perform();
        }
    }
}