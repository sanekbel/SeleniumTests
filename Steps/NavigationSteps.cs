using BoDi;
using OpenQA.Selenium;
using SeleniumTests.Pages;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SeleniumTests.Steps
{
    [Binding]    
    public class NavigationSteps
    {
        private IWebDriver _driver;
        private BasePage _page;
        public NavigationSteps(IObjectContainer objectContainer)
        {
            _driver = objectContainer.Resolve<IWebDriver>();
        }

        [Given(@"I am on the '(.*)' page")]
        public void GivenIAmOnThePage(BasePage page)
        {
            _page = page; 
            _page.Open();            
        }
        

        [When(@"I click '(.*)' page link on header")]
        public void WhenIClickPageLink(string link)
        {
            _page = _page.GetHeaderElement().ClickLink(link);
        }
        
        [Then(@"'(.*)' page should be open")]
        public void ThenPageShouldBeOpen(BasePage page)
        {            
            Assert.IsTrue(page.IsPageOpen(), $"Page {page} is not opened");
        }

    }
}
