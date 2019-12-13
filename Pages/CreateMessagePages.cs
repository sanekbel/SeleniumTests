using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Pages
{
    class CreateMessagePages : BasePage
    {
        public CreateMessagePages(IWebDriver driver)
        {
            _driver = driver;
            _title = "CreateMessages";
            _uri = "/Messages/Create";
            Configure();
        }
        public void MessageBoxText(string text)
        {
            var element = _driver.FindElement(By.Id("Message"));
            element.SendKeys(text);
        }        
    }
}
