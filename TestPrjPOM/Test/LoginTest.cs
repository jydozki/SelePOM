using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestPrjPOM.Pages;

namespace TestPrjPOM.Test
{
    class LoginTest
    {
        //Browser driver
        IWebDriver webDriver = new ChromeDriver();
        
        [SetUp]
        public void Setup()
        {
            //Goto site
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }



        [Test]
        public void Login()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("admin", "password");

            Assert.That(homePage.IsEmployeeListExist, Is.True);

            

        }
     

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
