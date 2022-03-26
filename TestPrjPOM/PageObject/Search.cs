using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestPrjPOM.PageObject
{
    class Search
    {
        private IWebDriver driver;

        public Search(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.LinkText, Using = ("Employee List"))]

        public IWebElement Employee { get; set; }
        [FindsBy(How=How.Name,Using=("searchTerm"))]
        
        public IWebElement SearchBox { get; set; }
        
        [FindsBy(How=How.XPath, Using =("/html/body/div[2]/form/input[2]"))]
        
        public IWebElement SearchButton { get; set; }

        [FindsBy(How=How.LinkText, Using =("Benefits"))]

        public IWebElement Action { get; set; }



        public void NavigateToResult()
        {
            SearchBox.SendKeys("Ramesh");
            
            SearchButton.Click();

            Action.Click();


            
        }


    }
}
