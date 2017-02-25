using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Remote;

namespace SeleniumProject.Frameworks
{
    [TestClass]
    public class SeleniumGrid
    {

        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = null;
            try
            {
                /*
    Start hub using below command
    java -jar server.jar -role hub -hubConfig myconfig.json

    Start node using below command. Please set the webdriver.chrome.driver property on node
    java -jar -Dwebdriver.chrome.driver="c:\chromedriver.exe" server.jar -role node -hub http://hubname:4444/grid/register -port 3333

    java -jar server.jar -role node -nodeConfig myconfig.json

    http://localhost:4444/grid/console
    */

                    driver = new RemoteWebDriver(
                            new Uri("http://localhost:4444/wd/hub"),
                            DesiredCapabilities.Chrome());

                    driver.Navigate().GoToUrl("http://www.softpost.org");
                    Console.WriteLine(driver.Title);
                    driver.Close();
                    driver.Quit();
                         
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
