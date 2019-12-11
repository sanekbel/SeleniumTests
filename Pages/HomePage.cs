using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Pages
{
    class HomePage : BasePage
    {        
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _title = "Index";
            _uri = "/";
            Configure();
        }
    }
}
