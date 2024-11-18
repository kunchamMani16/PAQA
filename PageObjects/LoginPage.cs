using OpenQA.Selenium;
using SwagLabsAutomation.Utilities;

namespace SwagLabsAutomation.PageObjects
{
    public class LoginPage
    {
        private WebDriver driver;
        private Utilities utilities;

        private By usernameInput = By.Id("user-name");
        private By passwordInput = By.Id("password");
        private By loginButton = By.Id("login-button");
        private By errorMessage = By.XPath("//*[@data-test='error']");

        public LoginPage(WebDriver driver)
        {
            this.driver = driver;
            utilities = new Utilities(driver);
        }

        public void NavigateToLoginPage()
        {
            utilities.OpenUrl("https://www.saucedemo.com");
        }

        public void EnterUsername(string username)
        {
            utilities.EnterText(usernameInput, username);
        }

        public void EnterPassword(string password)
        {
            utilities.EnterText(passwordInput, password);
        }

        public void ClickLoginButton()
        {
            utilities.ClickElement(loginButton);
        }

        public string GetErrorMessage()
        {
            return utilities.FindElement(errorMessage).Text;
        }
    }
}