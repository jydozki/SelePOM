using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPrjPOM.Pages
{
    class HomePage
    {

        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        private IWebDriver WebDriver { get; }
        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));

        // Register
        IWebElement lnkRegister => WebDriver.FindElement(By.LinkText("Register"));

        IWebElement lnkEmployeeList => WebDriver.FindElement(By.LinkText("Employee List"));
        //Create New Account
        IWebElement Username => WebDriver.FindElement(By.Id("UserName"));
        IWebElement Pass => WebDriver.FindElement(By.Id("Password"));
        IWebElement ConfirmPass => WebDriver.FindElement(By.Id("ConfirmPassword"));
        IWebElement Email => WebDriver.FindElement(By.Id("Email"));


        public void ClickLogin() => lnkLogin.Click();
        public bool IsEmployeeListExist() => lnkEmployeeList.Displayed;
        public void ClickRegister() => lnkRegister.Click();

        
        
    }

    
}
