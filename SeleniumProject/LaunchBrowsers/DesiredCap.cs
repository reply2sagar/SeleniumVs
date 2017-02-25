using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.PhantomJS;
using System.Collections.Generic;

namespace LaunchBrowsers
{
    [TestClass]
    public class DesiredCap
    {

        [TestMethod]
        public void TestChromeCap()
        {

            IWebDriver driver = null;
            try
            {
                ChromeOptions options = new ChromeOptions();
                // options.BinaryLocation = @"C:\Users\Sagar\Softwares\chrome.exe";
                //to get chrome details use -> chrome://version in address bar
                //options.AddArguments("user-data-dir=C:\\Users\\Sagar\\AppData\\Local\\Google\\Chrome\\User Data\\Default");
                //options.AddArguments("disable-popup-blocking");
                //options.AddArguments("test-type");
                options.AddArguments("start-maximized");
                //options.AddExtension(@"path-to-extension");

                options.EnableMobileEmulation("Apple iPhone 6");


                driver = new ChromeDriver(@"C:\Users\Sagar\Softwares", options);
                driver.Url = "http://www.softpost.org";
                //driver.Manage().Window.Maximize();
                driver.Navigate();
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
        public void TestFirefoxCap()
        {

            IWebDriver driver = null;
            try
            {
                FirefoxOptions options = new FirefoxOptions();
                options.LogLevel = FirefoxDriverLogLevel.Info;
                // options.Profile = new FirefoxProfile("profile-name");
                options.UseLegacyImplementation = false;
                driver = new FirefoxDriver(options);
                
               
                driver.Url = "http://www.softpost.org";
                driver.Manage().Window.Maximize();
                driver.Navigate();
                Console.WriteLine("Success");

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
        public void TestIE()
        {

            IWebDriver driver = null;
            InternetExplorerOptions options = new InternetExplorerOptions();
            
            options.EnableFullPageScreenshot = true;
            options.EnsureCleanSession = true;

            try
            {
                driver = new InternetExplorerDriver(@"C:\Users\Sagar\Softwares");
                driver.Url = "http://www.softpost.org";
                driver.Manage().Window.Maximize();
                driver.Navigate();
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
        public void TestSafari()
        {

            IWebDriver driver = null;
            try
            {
                SafariOptions options = new SafariOptions();
                
                driver = new SafariDriver();
                driver.Url = "http://www.softpost.org";
                driver.Manage().Window.Maximize();
                driver.Navigate();
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
        public void TestEdge()
        {

            IWebDriver driver = null;
            try
            {
                EdgeOptions options = new EdgeOptions();
                options.PageLoadStrategy = EdgePageLoadStrategy.Default;
                
                driver = new EdgeDriver();
                driver.Url = "http://www.softpost.org";
                driver.Manage().Window.Maximize();
                driver.Navigate();
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
        public void TestPhantomJs()
        {

            IWebDriver driver = null;
            try
            {
                PhantomJSOptions options = new PhantomJSOptions();
                
                driver = new PhantomJSDriver();
                driver.Url = "http://www.softpost.org";
                driver.Manage().Window.Maximize();
                Console.WriteLine("Title is " + driver.Title);

                driver.Navigate();
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

