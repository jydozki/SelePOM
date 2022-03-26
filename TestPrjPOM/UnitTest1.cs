using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestPrjPOM
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        

        [Test]
        public void Test1()
        {
            //Browser driver
            IWebDriver webDriver = new ChromeDriver();
            //By UserName = webDriver.FindElement(By.LinkText("Password"));

            //Goto site
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            //Identify element
            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Login"));

            //Operation
            lnkLogin.Click();

            //UserName
            var txtUserName = webDriver.FindElement(By.Name("UserName"));
            //Assert.Pass();
            var txtPassword = webDriver.FindElement(By.Id("Password"));
            Assert.That(txtPassword.Displayed, Is.True);
            //login
            txtUserName.SendKeys("admin");
            webDriver.FindElement(By.Name("Password")).SendKeys("password");
            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
            //Logoff
            webDriver.FindElement(By.LinkText("Log off")).Submit();
            //View Employee List
            webDriver.FindElement(By.LinkText("Employee List")).Click();
            //Assert
            var Searchbtn = webDriver.FindElement(By.XPath("//input[@value='Search']"));
            Assert.That(Searchbtn.Displayed, Is.True);

            //Operation 
            webDriver.Close();

        }
    }
}