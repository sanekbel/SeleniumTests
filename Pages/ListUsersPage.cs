using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Pages
{
    class ListUsersPage : BasePage
    {
        public ListUsersPage(IWebDriver driver)
        {
            _driver = driver;
            _title = "List of Users";
            _uri = "/User/ListUsers";
            Configure();
        }
    }
}
