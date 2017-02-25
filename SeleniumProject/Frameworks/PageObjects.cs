using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using SeleniumProject.Frameworks.Pages;

namespace SeleniumProject.Frameworks
{
    [TestClass]
    public class PageObjects
    {

        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                driver.Manage().Window.Maximize();

                HomePage homePage = new HomePage(driver);
                TestPage testPage = homePage.clickTestPageLink();
                testPage.setName("Paul");

                //doing assertions
                Assert.AreEqual("Paul", testPage.getName());

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception ....*********" + e.ToString());
            }

            finally
            {
                Thread.Sleep(2000);
                driver.Close();
                driver.Quit();

            }
        }
    }
}
