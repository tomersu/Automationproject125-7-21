using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automationproject125_7_21.Base;
 using Automationproject125_7_21.Steps;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace Automationproject125_7_21.Pages
{
   public class OrangeHrmTabChange : SetUp_Hooks
    {
        public IWebDriver driver;

        public OrangeHrmTabChange(IWebDriver browser)

        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }
        
        string OrangeHrmUrl = "https://opensource-demo.orangehrmlive.com/";
        [FindsBy(How=How.LinkText , Using = "Forgot your password?")]
        public IWebElement ForgotPassword; 
        /*[FindsBy(How=How.CssSelector, Using = "img[alt='OrangeHRM on youtube']")]
        public IWebElement Youtubeicon;
        [FindsBy(How = How.CssSelector, Using = "img[alt='YouTube']")]
        public IWebElement YouTubeTxt;
        [FindsBy(How = How.CssSelector, Using = "h1[class='SGW9xe']")]
        public IWebElement YOUtubeTxtVsible;*/
        //Facebook
        [FindsBy(How = How.CssSelector, Using = "img[alt='OrangeHRM on Facebook']")]
        public IWebElement Facebookicon;
       /* [FindsBy(How = How.CssSelector, Using = "img[alt='YouTube']")]
        public IWebElement FacebookTxt;
        [FindsBy(How = How.CssSelector, Using = "h1[class='SGW9xe']")]
        public IWebElement FacebookVsible;*/



        public void NavigatetoOrangehrmdemo()
        {
            driver.Navigate().GoToUrl(OrangeHrmUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // SearchTxtBox.SendKeys("Saree");
        }
        public void Forgotpasswordclick()
        {
            ForgotPassword.Click();
            //Thread.Sleep(3000);
        }
            
        public void Facebookiconclick()
        {
            string parentwinhandle = driver.CurrentWindowHandle;
            //Youtubeicon.Click();
            Facebookicon.Click();
            //Thread.Sleep(3000);

            // int Winhandle=driver.WindowHandles.Count();
            /*List<string> winhandle=driver.WindowHandles.ToList();
            foreach(var handle in winhandle)
            {
                Console.WriteLine(handle);
               //Switch to the desired window first and then execute commands using driver
                //driver.SwitchTo().Window(handle);
               // driver.Navigate().GoToUrl("https://google.com");
            }*/
            // driver.SwitchTo().Window(driver.WindowHandles[Winhandle-1]);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }
        public void CheckchildTab()
        {
            //driver.Url.Contains("https://consent.youtube.com/m?continue=https%3A%2F%2Fwww.youtube.com%2Forangehrm&gl=GB&m=0&pc=yt&uxe=23983171&hl=en-GB&src=1").Should().BeTrue();
            driver.Url.Contains("https://www.facebook.com/OrangeHRM").Should().BeTrue();
        }
        public void ParentTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            //Thread.Sleep(3000);
            driver.Url.Contains("https://opensource-demo.orangehrmlive.com/index.php/auth/requestPasswordResetCode").Should().BeTrue();
           // Thread.Sleep(3000);
        }
    }
}
