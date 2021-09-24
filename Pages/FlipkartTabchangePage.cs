using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Automationproject125_7_21.Base;

//using OpenQA.Selenium.Support.PageObjects;

namespace NewTab.Pages
{
    public class FlipkartTabchangePage: Base.SetUp
    {
        public IWebDriver driver;

        public FlipkartTabchangePage(IWebDriver browser)

        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }
        driver.navigate().goToUrl("https://www.flipkart.com/");
    }
}
