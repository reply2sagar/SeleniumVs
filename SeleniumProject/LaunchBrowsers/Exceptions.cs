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
        public class Exceptions
        {

            [TestMethod]
            public void TestExceptions()
            {


                IWebDriver driver = null;
               
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                    driver.Url = "http://www.softpost.org";
                    driver.Manage().Window.Maximize();
                    
                    driver.Navigate().GoToUrl("http://www.softpost.org");

                //NoSuchElementException
                 //driver.FindElement(By.Id("sss"));

                //ElementNotVisibleException

                //NoSuchFrameException
                //driver.SwitchTo().Frame("xyz");

                //NoSuchWindowException

                //InvalidSelectorException
                driver.FindElement(By.XPath("sss]"));

                Thread.Sleep(2000);
                    driver.Close();
                    driver.Quit();
                          
                
            }
        }
    }
     
}

