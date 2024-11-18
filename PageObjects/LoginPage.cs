using OpenQA.Selenium;
using SauceDemoAutomation.Utils;

namespace SauceDemoAutomation.PageObjects
{
    public class LoginPage : BasePage
    {
        private By UsernameField => By.Id("user-name");
        private By PasswordField => By.Id("password");
        private By LoginButton => By.Id("login-button");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void EnterUsername(string username)
        {
            Driver.FindElement(UsernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            Driver.FindElement(PasswordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            Driver.FindElement(LoginButton).Click();
        }
    }
}