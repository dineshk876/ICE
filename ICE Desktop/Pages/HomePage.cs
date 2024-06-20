using Nest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace BDD_AutomationTests.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By Location = By.XPath("//select[@id='selUserLocationIndex']");
        By Location1 = By.XPath("//select[@id='selUserLocationIndex']");
        By submit = By.XPath("//input[@id='btnSubmit']");
        By Frame = By.XPath("//iframe[@id='iframeMain']");
        By homePageAssertion = By.CssSelector("td:nth-child(2) > table tr:nth-child(2) > td");


        public void HomePageDisplayed()
        {
            driver.FindElement(Location).Click();
           IWebElement _secloc = driver.FindElement(Location1);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            wait.Until(e => (_secloc));
            OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(driver);
                for (int i=0; i<17; i++) 
            { 
                actions.SendKeys(Keys.ArrowDown).Perform(); 
            }
            driver.FindElement(submit).Click();
            IWebElement _frame = driver.FindElement(Frame);
            driver.SwitchTo().Frame(_frame);
            IWebElement _assert = driver.FindElement(homePageAssertion);
            string _valid = _assert.Text;
            Assert.That(_valid, Is.EqualTo("User:sunquest"), "error");
        }
        
    }
}