using System;
using TechTalk.SpecFlow;
using Automationproject125_7_21.Base;
using Automationproject125_7_21.Pages;



namespace Automationproject125_7_21.Steps
{
    [Binding]
    [Scope(Tag = "BMIFootersScroll")]
    public class BMIScrollSteps : SetUp_Hooks
    {
        BMIScrollPage ScrollPage;
        [Given(@"I navigate to BMI group website")]
        public void GivenINavigateToBMIGroupWebsite()
        {
            ScrollPage = new BMIScrollPage(driver);
            ScrollPage.navigatetoBMI();
        }
        
        [When(@"I scroll down to the footer")]
        public void WhenIScrollDownToTheFooter()
        {
            ScrollPage.ScrollDowntoLastElement();
            ScrollPage.ScrolluptoBeregningsprogramheading();
        }
        
        [Then(@"I can see the footer list")]
        public void ThenICanSeeTheFooterList()
        {
            ScrollPage.CheckScrollToLastElement();
        }
    }
}
