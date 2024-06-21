using Nest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

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
        By table = By.XPath("//form[@id='frmToolbar']/descendant::table[1]/tbody[1]");
        By tbr = By.XPath("//body[1]/form[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]");
        By tbd = By.XPath("//body[1]/form[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]");
        By logout_tab = By.XPath("//div[@id='Log Off']");
        By signout = By.LinkText("Log Off and Close Window");

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

        public void Logout()
        {
            Thread.Sleep(4000);
            IWebElement _tbl= driver.FindElement(table);
           IList <IWebElement> _tbr = _tbl.FindElements(tbr);
            foreach (IWebElement row in _tbr)
            {
                IList<IWebElement> _tbd = row.FindElements(tbd);
                foreach (IWebElement cell in _tbd)
                {
                    if (cell.Text == "Log Off and Close Window")
                    {
                        cell.Click();
                    }
                }
            }
           /* driver.FindElement(logout_tab).Click();
            driver.FindElement(signout).Click();*/
        }
    }
}