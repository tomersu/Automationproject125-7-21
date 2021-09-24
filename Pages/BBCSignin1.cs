using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework.Internal;
//using System.Drawing.Imaging;

namespace Automationproject125_7_21.Pages
{
    public class BBCSignin1
    {
        public IWebDriver driver;

        public BBCSignin1(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }

        string BBCUrl = "https://www.bbc.co.uk/";
        
        string account = "Your account";

        [FindsBy(How = How.LinkText, Using = "Sign in")]
        public IWebElement SignInLink;

        [FindsBy(How = How.Id, Using = "user-identifier-input")]
        public IWebElement Username;

        [FindsBy(How = How.Id, Using = "password-input")]
        public IWebElement Password;

        [FindsBy(How = How.Id, Using = "submit-button")]
        public IWebElement SignInButton;

        [FindsBy(How = How.LinkText, Using = "Your account")]
        public IWebElement SignInAccount;

        [FindsBy(How = How.CssSelector, Using = "span.ssrcss-qgttmg-AccountText.eki2hvo4")]
        public IWebElement YourAccount;

        public void navigate()
        {
            driver.Navigate().GoToUrl(BBCUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
            //Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                //ss.SaveAsFile("C://Users//suman//Desktop//TestFolderC//Test.png", ScreenshotImageFormat.Png);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C://Users//suman//Desktop//TestFolderC//Test.png",
            ScreenshotImageFormat.Png);
                   }
        public void ClickSignIn()
        {
            SignInLink.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void Login()
        {
            Username.SendKeys("sumantomer@gmail.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Password.SendKeys("BBCSignin12!");
            SignInButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
        public void CheckLogin()
        {
            YourAccount.Text.Contains(account).Should().BeTrue();
        }

    }
}
