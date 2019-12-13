using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Pages
{
    public class IndexPage : BasePage
    {        
        public IndexPage(IWebDriver driver)
        {
            _driver = driver;
            _title = "Index";
            _uri = "/";
            Configure();
        }
        public void CreateAMessage()
        {
            var element = _driver.FindElement(By.LinkText("Create a Message"));
            element.Click();
        }
    }
}
