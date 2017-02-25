using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.ObjectModel;

namespace SeleniumProject.Frameworks.Pages
{
    class HomePage : BasePage
    {

        [FindsBy(How = How.PartialLinkText, Using = "Selenium Test Page")]
        public IWebElement testLink { get; set; }

        public HomePage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("http://www.softpost.org");
        }

        public TestPage clickTestPageLink()
        {
           
            String mainWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Current window handle -> " + mainWindowHandle);

            //driver.FindElement(By.LinkText("Selenium Test Page")).Click();
            testLink.Click();

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
            return new TestPage(driver);
        }
    }
}
