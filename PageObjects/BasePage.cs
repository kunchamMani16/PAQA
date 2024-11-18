using OpenQA.Selenium;

namespace SauceDemoAutomation.PageObjects
{
    public class BasePage
    {
        protected IWebDriver Driver { get; private set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}