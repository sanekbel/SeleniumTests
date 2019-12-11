using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SeleniumTests.Steps
{
    [Binding]
    public class HelloWorldSteps
    {
        private IWebDriver _driver;
        public HelloWorldSteps(IObjectContainer objectContainer)
        {
            _driver = objectContainer.Resolve<IWebDriver>();
        }

        [When(@"I opening ""(.*)""")]
        public void WhenIOpening(string site)
        {
            _driver.Navigate().GoToUrl(site);
        }
        
        [Then(@"I should see ""(.*)"" text")]
        public void ThenIShouldSeeText(string expectedText)
        {
            var actualText = _driver.FindElement(By.CssSelector("body")).Text;
            Assert.AreEqual(expectedText, actualText, "Text doesn`t match");
        }
    }
}
