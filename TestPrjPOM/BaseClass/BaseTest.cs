using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPrjPOM.BaseClass
{

    class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            using (var browser = new ChromeDriver(chromeOptions))

                //driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Url = "https://www.youtube.com/";
            driver.Url = "http://www.eaapp.somee.com";
            driver.Navigate().Refresh();
            
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
