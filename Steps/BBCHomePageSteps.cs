using System;
using TechTalk.SpecFlow;
using Automationproject125_7_21.Base;
using Automationproject125_7_21.Pages;
using OpenQA.Selenium;

namespace Automationproject125_7_21.Steps
{
    [Binding]
    [Scope(Tag = "BBCHomePage")]
    public class BBCHomePageSteps:SetUp_Hooks
    {
       public BBCHomePage page;
        //public IWebDriver Browser;
       
        [Given(@"I navigate to BBC home page")]
        public void GivenINavigateToBBCHomePage()
        {
            //Browser = driver;
            page = new BBCHomePage(driver);
            page.NavigateBBC();
        }
        
        [When(@"I click on Home menu")]
        public void WhenIClickOnHomeMenu()
        {
            page.ClickHomepage();
        }
        
        [Then(@"I see home page loads")]
        public void ThenISeeHomePageLoads()
        {
            page.CheckHomePage();
        }
    }
}
