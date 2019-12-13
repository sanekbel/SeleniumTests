using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Pages.Elements
{
    public class HeaderElement
    {
        private IWebDriver _driver;
        private IWebElement AboutLink
        {
            get { return _driver.FindElement(By.LinkText("About")); }
        }
        private IWebElement ListMessagesLink
        {
            get { return _driver.FindElement(By.LinkText("ListMessages")); }
        }
        private IWebElement IndexLink
        {
            get { return _driver.FindElement(By.LinkText("Index")); }
        }
        private IWebElement UsersLink
        {
            get { return _driver.FindElement(By.LinkText("Users")); }
        }
        public HeaderElement(IWebDriver driver)
        {
            _driver = driver;
        }
        public BasePage ClickLink(string link)
        {
            if (link == "About")
            {
                AboutLink.Click();
                return new AboutPage(_driver);
            }
            else if (link == "Index")
            {
                IndexLink.Click();
                return new IndexPage(_driver);
            }
            else if (link == "ListUsers")
            {
                UsersLink.Click();
                return new ListUsersPage(_driver);
            }
            else
            {
                ListMessagesLink.Click();
                return new ListMessagesPage(_driver);
            }
        }
    }
}
