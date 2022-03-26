using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPrjPOM.PageObject
{
    class Home
    {
        private IWebDriver driver;

        public Home(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = ("Employee List"))]

        public IWebElement Employee { get; set; }

        //[FindsBy(How = How.XPath, Using = ("/html/body/div[2]/form/input[2]"))]
        [FindsBy(How = How.LinkText, Using = ("Login"))]
        public IWebElement lnkLogin { get; set; }

        public void NavigateToSearch()
        {
            Employee.Click();
            //lnkLogin.Click();
            //SearchButton.Click();

        

        }
        
    }
}
