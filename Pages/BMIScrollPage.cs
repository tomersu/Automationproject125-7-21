using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using FluentAssertions;
using System.Threading;

namespace Automationproject125_7_21.Pages
{
   public  class BMIScrollPage
    {
        IWebDriver driver;
        public BMIScrollPage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Personvern og sikkerhet')]")]
        IWebElement LastElement;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Beregningsprogram')]")]
        IWebElement Beregningsprogramheading;
        public void navigatetoBMI()
        {
            driver.Navigate().GoToUrl("https://www.bmigroup.com/no/beregning-og-visualisering/");
            driver.Manage().Cookies.DeleteAllCookies();
            Thread.Sleep(3000);
            
        }
        public void ScrollDowntoLastElement()
        {//2 methods to scroll down to the end.
            //((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", LastElement);//Scroll to the element
            Thread.Sleep(5000);
        }
        public void ScrolluptoBeregningsprogramheading()
        {//2 methods to scroll down to the end.
            //((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", Beregningsprogramheading);//Scroll to the element
            Thread.Sleep(5000);
        }
        public void CheckScrollToLastElement()
        {//added two verifiers
          LastElement.Text.Contains("Personvern og sikkerhet").Should().BeTrue();
            //bool scrollpassed=LastElement.Displayed;
           //scrollpassed.Should().BeTrue();
            Thread.Sleep(5000);
        }

    }
}
