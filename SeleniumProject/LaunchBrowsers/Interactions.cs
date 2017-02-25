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
        public class Interactions
        {

            [TestMethod]
            public void TestInteractions()
            {
                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                    driver.Manage().Window.Maximize();                        
                    driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page");

                    IWebElement firstName = driver.FindElement(By.XPath("//input[@id='fn']"));

                    firstName.SendKeys("Donald");

                    //sending the special keys
                    firstName.SendKeys(Keys.Enter);
                    Console.WriteLine("Value entered is -> " + firstName.GetAttribute("value"));

                    

                    IWebElement cityElement = driver.FindElement(By.TagName("Select"));
                    SelectElement cityDropDown = new SelectElement(cityElement);

                    cityDropDown.SelectByText("Brisbane");

                    Console.WriteLine("Selected city -> " + cityDropDown.SelectedOption.Text);

                    IWebElement qtpCheckbox = driver.FindElement(By.XPath("//input[@value='QTP']"));
                    qtpCheckbox.Click();

                    Console.WriteLine("QTP checkbox selected? -> " + qtpCheckbox.Selected);
                    Console.WriteLine("QTP checkbox enabled? -> " + qtpCheckbox.Enabled);
                    Console.WriteLine("QTP checkbox displayed? -> " + qtpCheckbox.Displayed);


                    driver.FindElement(By.XPath("//input[@name='gender']")).Click();




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

