using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace SeleniumProject
{
    namespace LaunchBrowsers
    {
        [TestClass]
        public class UploadDownload
        {

            [TestMethod]
            public void TestUpload()
            {
                IWebDriver driver = null;
                try
                {
                    ChromeOptions options = new ChromeOptions();
                    options.AddUserProfilePreference("download.default_directory", @"D:\DataTest");
                    options.AddUserProfilePreference("disable-popup-blocking", true);
                    options.AddUserProfilePreference("profile.default_content_settings.popups", 0);
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares", options);
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page");

                    //Upload test
                    driver.FindElement(By.XPath("//input[@type='file']")).SendKeys("C:\\wamp64\\www\\index.php");
                    Thread.Sleep(3000);

                    //Download in chrome
                    driver.FindElement(By.LinkText("Download")).Click();
                    Thread.Sleep(10000);
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
            public void TestUploadFirefox()
            {
                IWebDriver driver = null;
                try
                {
                    FirefoxProfile profile = new FirefoxProfile();
                    profile.SetPreference("browser.download.folderList", "2");
                    profile.SetPreference("browser.download.dir", "C:\\Users\\Sagar\\Documents\\Photos");
                    profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/pdf,image/jpeg");

                    driver = new FirefoxDriver(profile);
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl("http://www.softpost.org/selenium-test-page");

                    //Upload test
                    driver.FindElement(By.XPath("//input[@type='file']")).SendKeys("C:\\wamp64\\www\\index.php");
                    Thread.Sleep(3000);

                    //Download in chrome
                    driver.FindElement(By.LinkText("Download")).Click();
                    Thread.Sleep(10000);
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

