using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestPrjPOM.Pages;

namespace TestPrjPOM.Test
{
    class RegisterTest
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
        public void Register()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickRegister();

            RegisterPage regPage = new RegisterPage(webDriver);
            //RegisterPage.Register("newuser", "pass", "confirmPass");

            //Assert.That(homePage.IsEmployeeListExist, Is.True);

        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}