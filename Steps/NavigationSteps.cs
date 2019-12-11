using BoDi;
using OpenQA.Selenium;
using SeleniumTests.Pages;
using System;
using TechTalk.SpecFlow;

namespace SeleniumTests.Steps
{
    [Binding]
    public class NavigationSteps
    {
        private IWebDriver _driver;
        public NavigationSteps(IObjectContainer objectContainer)
        {
            _driver = objectContainer.Resolve<IWebDriver>();
        }

        [Given(@"I am on the '(.*)' page")]
        public void GivenIAmOnThePage(string p0)
        {
            var page = new HomePage(_driver);
            page.Open();
        }
        
        [When(@"I click '(.*)' page link")]
        public void WhenIClickPageLink(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"'(.*)' page should be open")]
        public void ThenPageShouldBeOpen(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
