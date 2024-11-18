using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    public class utilities
    {
        private By _usernameField = By.Id("user-name");
        private By _passwordField = By.Id("password");
        private By _loginButton = By.Id("login-button");
        private By _errorMessage = By.CssSelector(".error-message-container");
        private By _productsPageTitle = By.ClassName("title");
    }
}
