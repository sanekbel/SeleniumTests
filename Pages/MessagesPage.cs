using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Pages
{
    class Messages : BasePage
    {
        public Messages(IWebDriver driver)
        {
            _driver = driver;
            _title = "ListMessages";
            _uri = "/";
            Configure();
        }
    }
}
