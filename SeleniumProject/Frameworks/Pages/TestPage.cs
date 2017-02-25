using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Frameworks.Pages
{
    class TestPage : BasePage
    {
       
        public TestPage(IWebDriver driver) : base(driver)
        {
          
        }

        public void setName(string v)
        {
            IWebElement firstName = driver.FindElement(By.XPath("//input[@id='fn']"));

            firstName.SendKeys(v);


            firstName.SendKeys(Keys.Enter);
        }

        public String getName()
        {
            return driver.FindElement(By.XPath("//input[@id='fn']")).GetAttribute("value");

        }
    }
}
