import io.cucumber.java.en.Given;
import io.cucumber.java.en.When;
import io.cucumber.java.en.Then;
import org.junit.Assert;
import pages.LoginPage;
import pages.HomePage;
import utils.DriverUtils;

public class SwagLabsLoginSteps {

    private LoginPage loginPage;
    private HomePage homePage;

    public SwagLabsLoginSteps() {
        this.loginPage = new LoginPage(DriverUtils.getDriver());
        this.homePage = new HomePage(DriverUtils.getDriver());
    }

    @Given("User is on the Swag Labs login page")
    public void userIsOnSwagLabsLoginPage() {
        loginPage.navigateToLoginPage();
    }

    @When("User enters username {string} and password {string}")
    public void userEntersUsernameAndPassword(String username, String password) {
        loginPage.enterUsername(username);
        loginPage.enterPassword(password);
    }

    @When("User clicks on login button")
    public void userClicksOnLoginButton() {
        loginPage.clickLoginButton();
    }

    @Then("User should be logged in successfully")
    public void userShouldBeLoggedInSuccessfully() {
        Assert.assertTrue("User is not logged in successfully", homePage.isLogoutButtonDisplayed());
    }

    @Then("User should see an error message {string}")
    public void userShouldSeeErrorMessage(String errorMessage) {
        Assert.assertEquals("Error message is not displayed as expected", errorMessage, loginPage.getErrorMessage());
    }
}
