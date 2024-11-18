using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SauceDemoAutomation.Utils
{
    public class Utilities
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public Utilities(IWebDriver webDriver)
        {
            driver = webDriver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement FindElement(By locator)
        {
            return driver.FindElement(locator);
        }

        public void Click(By locator)
        {
            FindElement(locator).Click();
        }

        public void EnterText(By locator, string text)
        {
            FindElement(locator).SendKeys(text);
        }

        public void WaitForElementToBeClickable(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public void WaitForElementToBeVisible(By locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}