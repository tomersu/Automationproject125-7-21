using System;
using TechTalk.SpecFlow;
using Automationproject125_7_21.Base;
using Automationproject125_7_21.Steps;
using Automationproject125_7_21.Pages;
using OpenQA.Selenium;


namespace Automationproject125_7_21.Steps
{
    [Binding]
    [Scope(Tag= "BBCSignin1")]
    public class BBCSignin1Steps : SetUp_Hooks
    {
        public BBCSignin1 signin;
        public IWebDriver Browser;
        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            signin = new BBCSignin1(Browser);
            signin.navigate();
        }
        
        [When(@"I click Signin")]
        public void WhenIClickSignin()
        {
            signin.ClickSignIn();

        }

        [When(@"I login to BBC")]
        public void WhenILoginToBBC()
        {
            signin.Login();
        }


    

    [Then(@"I am logged in successfully")]
        public void ThenIAmLoggedInSuccessfully()
        {
            signin.CheckLogin();
        }
    }
}
