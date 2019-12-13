using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Pages
{
    class ListMessagesPage : BasePage
    {
        public ListMessagesPage(IWebDriver driver)
        {
            _driver = driver;
            _title = "ListMessages";
            _uri = "/Messages/ListMessages";
            Configure();
        }
    }
}
