using TechTalk.SpecFlow;
using SwagLabsAutomation.PageObjects;
using SwagLabsAutomation.Utilities;

namespace SwagLabsAutomation.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage loginPage;
        private Utilities utilities;

        public LoginSteps()
        {
            WebDriver driver = ScenarioContext.Current.Get<WebDriver>("WebDriver");
            loginPage = new LoginPage(driver);
            utilities = new Utilities(driver);
        }

        [Given("The Swag Labs website is opened")]
        public void GivenTheSwagLabsWebsiteIsOpened()
        {
            loginPage.NavigateToLoginPage();
        }

        [When("I enter username '(.*)' and password '(.*)'")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
        }

        [When("I click on the Login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            // Add assertion for successful login
            // Example: Assert.IsTrue(loginPage.IsLoggedIn());
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Add assertion for error message
            // Example: Assert.IsTrue(loginPage.GetErrorMessage().Contains("error"));
        }
    }
}