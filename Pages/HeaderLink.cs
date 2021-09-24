using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
namespace Automationproject125_7_21.Pages
{
    public class HeaderLink
    {
        public IWebDriver driver;

        public HeaderLink(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }
       string BBCUrl = "https://www.bbc.co.uk/";
        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement HomeLink;
        [FindsBy(How = How.LinkText, Using = "News")]
        public IWebElement NewsLink;
        [FindsBy(How = How.LinkText, Using = "Sport")]
        public IWebElement SportLink;
        [FindsBy(How = How.LinkText, Using = "Weather")]
        public IWebElement WeatherLink;
        string HomeUrl = "https://www.bbc.co.uk/";
        string NewsUrl = "https://www.bbc.co.uk/news";
        string SportUrl = "https://www.bbc.co.uk/sport";
        string WeatherUrl = "https://www.bbc.co.uk/weather";
        public void navigate()
        {
            driver.Navigate().GoToUrl(BBCUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void ClickHeaderLinks(string link)
        {
            switch(link)
            {
                case "Home":HomeLink.Click();
                    break;
                case "News":
                    NewsLink.Click();
                    break;
                case "Sport":
                    SportLink.Click();
                    break;
                case "Weather":
                    WeatherLink.Click();
                    break;
                default: Console.WriteLine("woring link provided");
                    break;

            }
        }
        public void CheckHeaderLinkpath(string link)
        {
            switch (link)
            {
                case "Home":
                    driver.Url.Contains(HomeUrl).Should().BeTrue();
                    
                    break;
                case "News":
                    driver.Url.Contains(NewsUrl).Should().BeTrue();
                    
                    break;
                case "Sport":
                    driver.Url.Contains(SportUrl).Should().BeTrue();
                    break;
                case "Weather":
                    driver.Url.Contains(WeatherUrl).Should().BeTrue();
                    break;
                default:
                    Console.WriteLine("working link provided");
                    break;

            }
        }


    }
}
