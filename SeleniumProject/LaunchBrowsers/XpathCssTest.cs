using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumProject
{
    namespace LaunchBrowsers
    {
        [TestClass]
        public class XpathCssTest
        {

            [TestMethod]
            public void TestXpathCss()
            {


                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                    driver.Manage().Window.Maximize();                        
                    driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page");

                    driver.FindElement(By.XPath("//input[@id='fn']")).SendKeys("Donald");

                    Thread.Sleep(3000);
                    driver.FindElement(By.XPath("//input[contains(@id,'fn')]")).Clear();

                    driver.FindElement(By.CssSelector("input[id='fn']")).SendKeys("Trump");


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

