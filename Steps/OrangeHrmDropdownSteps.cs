using System;
using TechTalk.SpecFlow;
using Automationproject125_7_21.Pages;
using Automationproject125_7_21.Base;

namespace Automationproject125_7_21.Steps
{
    [Binding]
    [Scope(Tag = "HrmOrangeDropdown")]
    public class OrangeHrmDropdownSteps:SetUp_Hooks
    {
        OrangeHrmDropdownPage Pagehrm;
        [Given(@"I want to navigate to HrmOrange")]
        public void GivenIWantToNavigateToHrmOrange()
        {
            Pagehrm = new OrangeHrmDropdownPage(driver);
            Pagehrm.Navigatetourl();           
        }
        
        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword()
        {
            Pagehrm.Enterusernamepassword();
        }
        
        [Given(@"I click on Login button")]
        public void GivenIClickOnLoginButton()
        {
            Pagehrm.LoginBtn();
        }
        
        
        [Given(@"I click on Pim tab")]
        public void GivenIClickOnPimTab()
        {
            Pagehrm.PimClick();
        }

        [Given(@"I select Full-Time Contract in Empolyment Status")]
        public void GivenISelectFull_TimeContractInEmpolymentStatus()
        {
            Pagehrm.SelectEmploymentStatus();
        }

        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            Pagehrm.Search();
        }

        [Then(@"the result of Job Title and Employment Status should be verified")]
        public void ThenTheResultOfJobTitleAndEmploymentStatusShouldBeVerified()
        {
            Pagehrm.checkJobTitleEmploymentStatus();
        }



        [Given(@"I select account assistant in job title")]
        public void GivenISelectAccountAssistantInJobTitle()
        {
            Pagehrm.SelectJobtitle();
           
        }
        
       
    }
}
