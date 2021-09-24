using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automationproject125_7_21.Base;

namespace Automationproject125_7_21.Pages
{
    public class BBCHomePage
    {
     public IWebDriver driver;
        
        public BBCHomePage(IWebDriver browser)
           
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }
        
        string BBCUrl = "https://www.bbc.co.uk/";
        [FindsBy(How = How.LinkText, Using="Home")]
        public IWebElement HomeLink;       

        public void NavigateBBC()
        {
            driver.Navigate().GoToUrl("https://bbc.co.uk/");
        }
        public void ClickHomepage()
        {
            HomeLink.Click();
        }
        public void CheckHomePage()
        {
            driver.Url.Contains(BBCUrl).Should().BeTrue();
           
        }
    }
}
