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
        public class JavaScriptExecutor
        {

            [TestMethod]
            public void TestJS()
            {
                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                    driver.Manage().Window.Maximize();                        
                    driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page");

                    //Clicking on element
                    IWebElement qtpCheckbox = driver.FindElement(By.XPath("//input[@value='QTP']"));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", qtpCheckbox);

                    //Setting data in edit box
                    IWebElement firstName = driver.FindElement(By.XPath("//input[@id='fn']"));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='Shaun';", firstName);

                    //Setting data in edit box
                    IWebElement cucumber = driver.FindElement(By.PartialLinkText("Cucumber"));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();;", cucumber);


                    //Firing the change event
                    String changeEvent = "var evt = document.createEvent('HTMLEvents');";
                    changeEvent = changeEvent + "evt.initEvent('change');";
                    changeEvent = changeEvent + "arguments[0].dispatchEvent(evt);";

                    ((IJavaScriptExecutor)driver).ExecuteScript(changeEvent, firstName);


                    //Get the innerHTML of the document
                    String documentText = ((IJavaScriptExecutor)driver).ExecuteScript("return document.documentElement.innerHTML;").ToString();
                    Console.WriteLine("InnerHTML -> " + documentText);

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

