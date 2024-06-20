using BDD_AutomationTests.Pages;

namespace BDD_AutomationTests.Behavior
{
    public class ExecuteLoginBehavior
    {
        private LoginPage loginPage;
        private string userName;
        private string password;
        public ExecuteLoginBehavior(LoginPage page, string userName, string password)
        {
            loginPage = page;
            this.userName = userName;
            this.password = password;
        }
        public void Perform()
        {
            loginPage.ExecuteLogin(userName, password);
        }
    }
}