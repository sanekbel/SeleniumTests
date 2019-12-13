using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumTests.Pages.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;
        protected string _url;
        protected string _title;
        protected string _uri;
        protected HeaderElement _headerElement;

        public HeaderElement GetHeaderElement()
        { 
            return _headerElement; 
        }
        protected IWebElement TitleElement
        { 
            get { return _driver.FindElement(By.CssSelector("h1")); }
        }        

        protected void Configure()
        {            
            var config = new ConfigurationBuilder()
                .AddJsonFile(System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.
                    GetExecutingAssembly().Location) + "/dev-config.json")
                .Build();

            _url = config["baseUrl"] + _uri;
            _headerElement = new HeaderElement(_driver);
        }

        public BasePage Open()
        {
            _driver.Navigate().GoToUrl(_url);
            return this;
        }
        public bool IsPageOpen()
        {
            return TitleElement.Text == _title;
        }
        public void FindAndClickLink(string link)
        {
            var element = _driver.FindElement(By.LinkText(link));
            element.Click();
        }        
    }
}
