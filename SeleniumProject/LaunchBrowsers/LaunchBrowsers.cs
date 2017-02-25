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
namespace SeleniumProject
{
    namespace LaunchBrowsers
    {
        [TestClass]
        public class LaunchBrowsers
        {

            [TestMethod]
            public void TestChrome()
            {


                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver(@"C:\Users\Sagar\Softwares");
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
            public void TestIE()
            {



                IWebDriver driver = null;
                //InternetExplorerOptions op = new InternetExplorerOptions();
              
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
            public void TestFirefox()
            {

                IWebDriver driver = null;
                try
                {
                    driver = new FirefoxDriver();
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
     
    }

