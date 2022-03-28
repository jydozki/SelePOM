using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPrjPOM.Pages
{
    class RegisterPage 
    {
        public RegisterPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebDriver WebDriver { get; }
        IWebElement Username => WebDriver.FindElement(By.Id("UserName"));
        IWebElement Pass => WebDriver.FindElement(By.Id("Password"));
        IWebElement ConfirmPass => WebDriver.FindElement(By.Id("ConfirmPassword"));
        IWebElement Email => WebDriver.FindElement(By.Id("Email"));

        internal static void NavigateToLoginPage() => throw new NotImplementedException();

        //internal void Register(string Username, string pass, string confirmPass)
    }



}
