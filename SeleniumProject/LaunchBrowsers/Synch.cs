using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject
{
    namespace LaunchBrowsers
    {
        [TestClass]
        public class Synch
        {

            [TestMethod]
            public void TestSynch()
            {
                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page");

                    //Page load timeout specifies the maximum timeout for loading the pages
                    driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(50));


                    //Implicit timeout applies to all elements
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));



                   //Explicit timeout for specific elements based on conditions
                    WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                    w.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(InvalidElementStateException));
                    w.Until(ExpectedConditions.TitleContains("Selenium"));
                    w.Until(ExpectedConditions.ElementExists(By.Id("fn")));
                    w.Until(ExpectedConditions.ElementIsVisible(By.Id("fn")));
                    w.Until(ExpectedConditions.ElementToBeClickable(By.Id("fn")));
                    w.Until(ExpectedConditions.UrlContains("softpost"));
                    // w.Until(ExpectedConditions.AlertIsPresent());
                    // w.Until(ExpectedConditions.


                   driver.FindElement(By.XPath("//input[@id='fn']")).SendKeys("Donald");

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
     
}

