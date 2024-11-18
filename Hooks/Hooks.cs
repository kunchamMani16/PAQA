using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace SwagLabsAutomation.Hooks
{
    [Binding]
    public class Hooks
    {
        private WebDriver driver;

        [BeforeScenario]
        public void InitializeTest()
        {
            // Initialize WebDriver based on browser type (can be parameterized)
            string browserType = "chrome"; // default browser
            switch (browserType.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "ie":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            ScenarioContext.Current["WebDriver"] = driver;
        }

        [AfterScenario]
        public void TearDownTest()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}