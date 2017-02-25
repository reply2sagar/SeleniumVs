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
        public class ElementLocators
        {

            [TestMethod]
            public void TestLocators()
            {


                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");


                    Thread.Sleep(2000);
                    driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page/");

                    //find the element with id - fn
                    driver.FindElement(By.Id("fn")).SendKeys("hello");

                    //find the element with class - entry-title
                    String title = driver.FindElement(By.ClassName("entry-title")).Text;
                    Console.WriteLine("Title of the page is -> " + title);

                    Thread.Sleep(4000);
                    //find the element with name - gender
                    driver.FindElement(By.Name("gender")).Click();

                   // driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys("last name");

                    
                    driver.FindElement(By.TagName("input")).SendKeys("user");

                    driver.FindElement(By.LinkText("Git")).Click();
                    Thread.Sleep(2000);

                    driver.FindElement(By.PartialLinkText("Cucum")).Click();
                    Thread.Sleep(2000);
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


            [TestMethod]
            public void TestFindElements()
            {


                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                    driver.Url = "http://www.softpost.org";
                    driver.Manage().Window.Maximize();
                    driver.Navigate();

                    System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("a"));

                    Console.WriteLine("Total Links Count " + links.Count);

                    for (int k = 0; k < links.Count; k++)
                        Console.WriteLine(links[k].Text);


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

