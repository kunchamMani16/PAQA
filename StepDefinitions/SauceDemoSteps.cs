using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemoAutomation.PageObjects;
using SauceDemoAutomation.Utils;
using TechTalk.SpecFlow;

namespace SauceDemoAutomation.StepDefinitions
{
    [Binding]
    public class SauceDemoSteps
    {
        private readonly LoginPage loginPage;
        private readonly ProductsPage productsPage;

        public SauceDemoSteps(IWebDriver driver)
        {
            loginPage = new LoginPage(driver);
            productsPage = new ProductsPage(driver);
        }

        [Given("the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            loginPage.NavigateTo("https://www.saucedemo.com");
        }

        [When("the user enters valid credentials")]
        public void WhenTheUserEntersValidCredentials(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUsername((string)data.Username);
            loginPage.EnterPassword((string)data.Password);
        }

        [When("the user clicks on the login button")]
        public void WhenTheUserClicksOnTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("the user should be redirected to the product page")]
        public void ThenTheUserShouldBeRedirectedToTheProductPage()
        {
            Assert.IsTrue(productsPage.IsProductPageVisible(), "User is not redirected to the product page.");
        }
    }
}