import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class SauceDemoPage {
    private WebDriver driver;
    private WebDriverWait wait;

    public SauceDemoPage(WebDriver driver) {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, 10);
    }

    public void login(String username, String password) {
        WebElement usernameInput = driver.findElement(SauceDemoPageLocators.USERNAME_INPUT);
        WebElement passwordInput = driver.findElement(SauceDemoPageLocators.PASSWORD_INPUT);
        WebElement loginButton = driver.findElement(SauceDemoPageLocators.LOGIN_BUTTON);

        usernameInput.sendKeys(username);
        passwordInput.sendKeys(password);
        loginButton.click();
    }

    public void addToCart() {
        WebElement addToCartButton = driver.findElement(SauceDemoPageLocators.ADD_TO_CART_BUTTON);
        addToCartButton.click();
    }

    public void checkout() {
        WebElement shoppingCartIcon = driver.findElement(SauceDemoPageLocators.SHOPPING_CART_ICON);
        shoppingCartIcon.click();

        WebElement checkoutButton = driver.findElement(SauceDemoPageLocators.CHECKOUT_BUTTON);
        checkoutButton.click();
    }

    public void enterShippingInformation(String firstName, String lastName, String zipCode) {
        WebElement firstNameInput = driver.findElement(SauceDemoPageLocators.FIRST_NAME_INPUT);
        WebElement lastNameInput = driver.findElement(SauceDemoPageLocators.LAST_NAME_INPUT);
        WebElement zipCodeInput = driver.findElement(SauceDemoPageLocators.ZIP_CODE_INPUT);

        firstNameInput.sendKeys(firstName);
        lastNameInput.sendKeys(lastName);
        zipCodeInput.sendKeys(zipCode);
    }

    public void completeOrder() {
        WebElement continueButton = driver.findElement(SauceDemoPageLocators.CONTINUE_BUTTON);
        continueButton.click();

        WebElement finishButton = driver.findElement(SauceDemoPageLocators.FINISH_BUTTON);
        finishButton.click();
    }

    public boolean isOrderSuccessful() {
        WebElement thankYouHeader = wait.until(ExpectedConditions.visibilityOfElementLocated(SauceDemoPageLocators.THANK_YOU_HEADER));
        return thankYouHeader.isDisplayed();
    }
}
