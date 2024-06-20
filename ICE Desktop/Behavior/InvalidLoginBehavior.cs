using BDD_AutomationTests.Pages;

namespace BDD_AutomationTests.Behavior
{
    public class InvalidLoginBehavior
    {        
        private LoginPage loginPage;
        public InvalidLoginBehavior(LoginPage page)
        {
            loginPage = page;
        }
        public void Perform()
        {
            loginPage.InvalidAccountMessage();
        }
    }
}