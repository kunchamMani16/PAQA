using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SauceDemoAutomation.Hooks
{
    [Binding]
    public class SauceDemoHooks
    {
        private readonly IWebDriver driver;

        public SauceDemoHooks()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            // WebDriver initialization logic, if any
        }

        [AfterScenario]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        // Add any additional setup or cleanup methods here as needed
    }
}