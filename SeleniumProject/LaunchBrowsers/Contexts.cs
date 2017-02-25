using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace SeleniumProject
{
    namespace LaunchBrowsers
    {
        [TestClass]
        public class Contexts
        {

            [TestMethod]
            public void TestContexts()
            {


                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                    driver.Manage().Window.Maximize();                        
                    driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page");

                    //Handling alerts
                    IWebElement signUpButton = driver.FindElement(By.XPath("//input[@name='Sign up']"));
                    signUpButton.Click();

                    driver.SwitchTo().Frame(1);
                    IAlert alert = driver.SwitchTo().Alert();
                    alert.Accept();
                    Console.WriteLine("Text on alert is -> " + alert.Text);
                    //alert.Dismiss();

                    //Handling frames
                    driver.SwitchTo().Frame("g");
                    driver.FindElement(By.PartialLinkText("JSON")).Click();

                    Thread.Sleep(3000);

                    //Switching default content
                    driver.SwitchTo().DefaultContent();
                    String mainWindowHandle = driver.CurrentWindowHandle;
                    Console.WriteLine("Current window handle -> " + alert.Text);

                    driver.FindElement(By.PartialLinkText("Cucumber")).Click();

                    //get the collection of all open windows
                    ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
                    String newWindowHandle = "";
                    foreach (string handle in windowHandles)
                    {
                        if (handle != mainWindowHandle)
                        {
                            newWindowHandle = handle;
                            break;
                        }
                    }

                    //switch to new pop up window
                    // and perform any operation you want to perform
                    driver.SwitchTo().Window(newWindowHandle);

                    Console.WriteLine("Title of new window is -> " + driver.Title);
                    driver.Close();

                    driver.SwitchTo().Window(mainWindowHandle);
                    Console.WriteLine("Title of old window is -> " + driver.Title);




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

