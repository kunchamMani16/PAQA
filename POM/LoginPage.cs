using OpenQA.Selenium;
using SwagLabsAutomation.Utilities;

namespace SwagLabsAutomation.PageObjects
{
    public class LoginPage
    {
        private WebDriver driver;
        private WebUtility utilities;

        private By usernameInput = By.Id("user-name");
        private By passwordInput = By.Id("password");
        private By loginButton = By.Id("login-button");
        private By product = By.XPath("//span[@data-test='title']");
        private By _errorMessage = By.CssSelector(".error-message-container");

        public LoginPage(WebDriver driver)
        {
            this.driver = driver;
            utilities = new WebUtility(driver);
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

        public bool IsProductsPageVisible()
        {
            IWebElement productsPageTitleElement = utilities.FindElement(product);
            return productsPageTitleElement != null && productsPageTitleElement.Displayed;
        }

        public bool IsErrorMessageVisible()
        {
            IWebElement errorMessageElement = utilities.FindElement(_errorMessage);
            return errorMessageElement != null && errorMessageElement.Displayed;
        }
    }
}