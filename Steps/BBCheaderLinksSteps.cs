using System;
using TechTalk.SpecFlow;
using Automationproject125_7_21.Base;
using Automationproject125_7_21.Pages;
using OpenQA.Selenium;
namespace Automationproject125_7_21.Steps
{
    [Binding]
    [Scope(Tag ="headers")]
    public class BBCheaderLinksSteps:SetUp_Hooks
    {
        public IWebDriver Browser;
        public HeaderLink header;
        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            header = new HeaderLink(driver);
            header.navigate();

        }
        
        [When(@"I click (.*) Links")]
        public void WhenIClickHomeLinks(string link)
        {
            header.ClickHeaderLinks(link);
        }
        
        [Then(@"I view (.*) link pages")]
        public void ThenIViewHomeLinkPages(string link)
        {
            header.CheckHeaderLinkpath(link);
        }
    }
}
