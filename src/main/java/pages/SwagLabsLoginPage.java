import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;

public class SwagLabsLoginPage {
    private WebDriver driver;

    public SwagLabsLoginPage(WebDriver driver) {
        this.driver = driver;
    }

    public void enterUsername(String username) {
        driver.findElement(By.id("user-name")).sendKeys(username);
    }

    public void enterPassword(String password) {
        driver.findElement(By.id("password")).sendKeys(password);
    }

    public void clickLoginButton() {
        driver.findElement(By.id("login-button")).click();
    }

    public String getErrorMessage() {
        return driver.findElement(By.cssSelector("[data-test='error']")).getText();
    }

    public void login(String username, String password) {
        enterUsername(username);
        enterPassword(password);
        clickLoginButton();
    }
}
