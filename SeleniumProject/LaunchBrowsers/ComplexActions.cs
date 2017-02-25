using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace SeleniumProject
{
    namespace LaunchBrowsers
    {
        [TestClass]
        public class ComplexActions
        {

            [TestMethod]
            public void TestActions()
            {


                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                    driver.Manage().Window.Maximize();                        
                    driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page");

                    IWebElement firstName = driver.FindElement(By.Id("fn"));
                    IWebElement city = driver.FindElement(By.TagName("Select"));

                    Actions actions = new Actions(driver);

                    //mouse over 
                    actions.MoveToElement(firstName).Build().Perform();

                    //drag and drop
                    //actions.DragAndDrop(firstName,city).Build().Perform();

                    //double click an element
                    actions.DoubleClick(firstName).Build().Perform();

                    //context click an element
                    actions.ContextClick(firstName).Build().Perform();
                    Thread.Sleep(2000);

                    //actions.ClickAndHold(firstName).MoveToElement(city).Release().Build().Perform();
                    


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

