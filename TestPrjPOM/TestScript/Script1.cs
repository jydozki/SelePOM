using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestPrjPOM.BaseClass;
using TestPrjPOM.PageObject;

namespace TestPrjPOM.TestScript
{
    class Script1:BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            var home = new Home(driver);

            var searchpage= new Search(driver);

            //searchpage.NavigateToResult();
            home.NavigateToSearch();

            Thread.Sleep(5000);
            searchpage.NavigateToResult();

            Thread.Sleep(5000);





        }
    }
}
