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
        public class BasicAutomation
        {

            [TestMethod]
            public void TestBasicAutomation()
            {


                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                    driver.Url = "http://www.softpost.org";
                    driver.Manage().Window.Maximize();
                          
                    driver.Navigate().GoToUrl("http://www.softpost.org");

                    Console.WriteLine("Page title is " + driver.Title);
                    Console.WriteLine("Page source is " + driver.PageSource);
                    Console.WriteLine("Page url is " + driver.Url);

                    driver.Navigate().Forward();
                   
                    Thread.Sleep(5000);
                    driver.Navigate().Back();
                   

                    driver.Manage().Window.Size = new System.Drawing.Size(222, 222);

                    Thread.Sleep(5000);

                    driver.Manage().Window.Position = new System.Drawing.Point(100, 200);
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

