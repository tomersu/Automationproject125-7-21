using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
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
  public    class OrangeHrmDropdownPage
    {
        public IWebDriver driver;
        public OrangeHrmDropdownPage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = ("txtUsername"))]
        IWebElement Username;
        [FindsBy(How = How.Id, Using = ("txtPassword"))]
        IWebElement Password;
        [FindsBy(How = How.Id, Using = ("btnLogin"))]
        IWebElement Login;
        [FindsBy(How = How.Id, Using = ("menu_recruitment_viewRecruitmentModule"))]
        IWebElement Recruitment;
        [FindsBy(How = How.Id, Using = ("menu_pim_viewPimModule"))]
        IWebElement Pim;

        [FindsBy(How = How.Id, Using = ("empsearch_job_title"))]
        IWebElement JobTitleDropdown;
        [FindsBy(How = How.Id, Using = ("empsearch_employee_status"))]
        IWebElement EmploymentStatusDropdown;

        [FindsBy(How = How.Id, Using = ("searchBtn"))]
        IWebElement SearchCandidates;
        [FindsBy(How = How.XPath, Using = ("//*[@id='resultTable']//td[contains(text(),'Account Assistant')]"))]
        IWebElement AccountAssistantTxt;
        [FindsBy(How = How.XPath, Using = ("//*[@id='resultTable']//td[contains(text(),'Full-Time Contract')]"))]
        IWebElement EmploymentStatusTxt;

        //*[@id='resultTable']/tbody/tr/td[2]
        public void Navigatetourl()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/login");
        }
        public void Enterusernamepassword()
        {
            Username.SendKeys("Admin");
            Password.SendKeys("admin123");
            
        }
        public void LoginBtn()
        {
            Login.Click();
            Thread.Sleep(3000);
        }
        public void PimClick()
        {
            Pim.Click();
            Thread.Sleep(3000);
        }
       /*public void VacancyClick()
        {
            Vacancy.Click();
            Thread.Sleep(3000);
        }*/
        public void SelectJobtitle()
        {
            SelectElement selectJob = new SelectElement(JobTitleDropdown);
            selectJob.SelectByText("Account Assistant");
            
            Thread.Sleep(3000);
        }
        public void SelectEmploymentStatus()
        {
            SelectElement selectJob = new SelectElement(EmploymentStatusDropdown);
            selectJob.SelectByValue("2");
            Thread.Sleep(3000);
        }
        public void Search()
        {
            Thread.Sleep(3000);
            SearchCandidates.Click();
            Thread.Sleep(3000);
        }
        public void checkJobTitleEmploymentStatus()
        {
            AccountAssistantTxt.Text.Contains("Account Assistant").Should().BeTrue();
            EmploymentStatusTxt.Text.Contains("Full-Time Contract").Should().BeTrue();
        }


    }
}
