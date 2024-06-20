using BDD_AutomationTests.Pages;

namespace BDD_AutomationTests.Behavior
{
    public class ValidLoginBehavior
    {
        private HomePage homePage;
        public ValidLoginBehavior(HomePage page)
        {
            homePage = page;
        }
        public void Perform()
        {
            homePage.HomePageDisplayed();
        }
    }
}