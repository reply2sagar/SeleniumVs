using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


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
            //driver.FindElement(By.LinkText("Selenium Test Page")).Click();
            testLink.Click();
            return new TestPage(driver);
        }
    }
}
