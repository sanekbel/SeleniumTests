using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumTests.Configuration
{
    [Binding]
    public sealed class Hooks
    {
        private IWebDriver _driver;

        private readonly IObjectContainer objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver(
                Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location));
            objectContainer.RegisterInstanceAs(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }

        [StepArgumentTransformation]        
        public BasePage Transform(string pageName)
        {
            if (pageName == "About") { return new AboutPage(_driver); }
            else if (pageName == "Index") { return new IndexPage(_driver); }
            else if (pageName == "ListUsers") { return new ListUsersPage(_driver); }
            else { return new ListMessagesPage(_driver); }
        }
    }
}
