using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumProject.Frameworks
{


    [TestClass]
    public class MsTest
    {
        IWebDriver driver = null;

        //[ClassCleanup]
        [TestCleanup]
        public void testClean()
        {       
                Thread.Sleep(2000);
                driver.Close();
                driver.Quit();
        }


        //[ClassInitialize]
        [TestInitialize]
        public void testInit()
        {
            driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
            driver.Manage().Window.Maximize();

        }

        

        [TestMethod]
        [TestCategory("sanity")]
       
        public void TestMethod1()
        {
//            MSTest location
//C:\Program Files(x86)\Microsoft Visual Studio\2017\Community\Common7\IDE

//MSBuild Location
//C:\Program Files(x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin

//mstest / testcontainer:SeleniumProject.dll

//mstest / testcontainer:SeleniumProject.dll / category:"sanity" / resultsfile:TestResults.trx

//  / category:group1
//   / category:"group1&group2"
//    / category:"group1|group2"
//     / category:"group1&!group2"

//      / test:"ns.TestClass"


          
            try
            {
                driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page");

                IWebElement firstName = driver.FindElement(By.XPath("//input[@id='fn']"));

                firstName.SendKeys("Donald");
                firstName.SendKeys(Keys.Enter);

                //doing assertions
                Assert.AreEqual("Donald",firstName.GetAttribute("value"));
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception ....*********" + e.ToString());
            }

           
        }


        [Ignore()]
        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Test Method 2");
        }

    }
}
