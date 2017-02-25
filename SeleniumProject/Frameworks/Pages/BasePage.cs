using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Frameworks.Pages
{
    
    class BasePage
    {
        public IWebDriver driver = null;
        public BasePage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
