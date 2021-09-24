using System;
using TechTalk.SpecFlow;
using Automationproject125_7_21.Base;
using Automationproject125_7_21.Pages;
using OpenQA.Selenium;

namespace Automationproject125_7_21.Steps 
{
    [Binding]
    [Scope(Tag = "OrangeHrmTabchange")]
    public class OrangeHrmChangeSteps : SetUp_Hooks
{
        //public IWebDriver driver;
        public OrangeHrmTabChange Tab;       
        
       

        [Given(@"I navigate to the OrangeHrmdemo homepage")]
        public void GivenINavigateToTheOrangeHrmdemoHomepage()
        {
            Tab = new OrangeHrmTabChange(driver);
            Tab.NavigatetoOrangehrmdemo();
        }

        [Given(@"I click on forgot password")]
        public void GivenIClickOnForgotPassword()
        {
            Tab.Forgotpasswordclick();
        }

        [When(@"I Click on youtube icon")]
        public void WhenIClickOnYoutubeIcon()
        {
            Tab.Facebookiconclick();
        }

        [Then(@"it opens a new tab for youtube")]
        public void ThenItOpensANewTabForYoutube()
        {
            Tab.CheckchildTab();
        }

        [Then(@"I come back to my Previous homepage tab\.")]
        public void ThenIComeBackToMyPreviousHomepageTab_()
        {
            Tab.ParentTab();
        }

    }
}
