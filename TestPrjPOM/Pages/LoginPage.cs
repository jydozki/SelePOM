using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPrjPOM.Pages
{
    class LoginPage 
    {
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;

        }

        private IWebDriver WebDriver { get; }

        IWebElement txtUsername => WebDriver.FindElement(By.Id("UserName"));
        IWebElement txtPass => WebDriver.FindElement(By.Id("Password"));
        IWebElement loginBtn => WebDriver.FindElement(By.XPath("//input[@value='Log in']"));
        IWebElement lnkRegister => WebDriver.FindElement(By.LinkText("Register"));
        public void ClickRegister() => lnkRegister.Click();

        internal void Login(string userName, string password)
       {  
            //txtUsername.SendKeys(userName);
            //txtPass.SendKeys(password);
           // loginBtn.Submit();
        }

    }
}
    
   

