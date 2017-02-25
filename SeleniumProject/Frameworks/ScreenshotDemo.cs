using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Drawing.Imaging;

namespace SeleniumProject.Frameworks
{
    [TestClass]
    public class ScreenshotDemo
    {

        [TestMethod]
     
        public void TestScreenshot()
        {

            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page");

                IWebElement firstName = driver.FindElement(By.XPath("//input[@id='fn']"));

                firstName.SendKeys("Donald");


                ITakesScreenshot screenshotDriver = (ITakesScreenshot)driver;

                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("d:\\photos\\abc.png", ImageFormat.Png);

                //http://www.thefriendlytester.co.uk/2012/11/take-screenshots-with-remotewebdriver.html
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
