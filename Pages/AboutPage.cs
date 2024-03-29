﻿using OpenQA.Selenium;
using SeleniumTests.Pages.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Pages
{
    class AboutPage : BasePage
    {        
        public AboutPage(IWebDriver driver)
        {
            _driver = driver;
            _title = "About";
            _uri = "/Home/About";
            Configure();
        }
    }
}
