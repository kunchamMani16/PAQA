using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SwagLabsAutomation.Utilities
{
    public class WebUtility
    {
        private WebDriver driver;
        private WebDriverWait wait;

        public WebUtility(WebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }


        public void OpenUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement FindElement(By locator)
        {
            return driver.FindElement(locator);
        }

        public void ClickElement(By locator)
        {
            FindElement(locator).Click();
        }

        public void EnterText(By locator, string text)
        {
            FindElement(locator).SendKeys(text);
        }

        public void WaitForVisibilityOfElement(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        // Add more utility methods as needed
    }
}