using BDD_AutomationTests.Behavior;
using BDD_AutomationTests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BDD_AutomationTests.StepDefinitions
{
    [Binding]
    public sealed class CommonStepDefinitions
    {
        private LoginPage loginPage;

        public CommonStepDefinitions(IWebDriver driver)
        {
            loginPage = new LoginPage(driver);
        }

        [Given(@"Login with credentials (.*) and (.*)")]
        public void WhenLoginWithValidCredentials(string userName, string password)
        {
            new ExecuteLoginBehavior(loginPage, userName, password).Perform();
        }
    }
}