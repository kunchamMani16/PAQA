Feature: Swag Labs Login

  As a user of Swag Labs
  I want to be able to log in with valid credentials
  So that I can access the secure area of the website

  Background:
    Given The Swag Labs website is opened

  Scenario: Successful login with standard user credentials
    When I enter username 'standard_user' and password 'secret_sauce'
    And I click on the Login button
    Then I should be redirected to the home page

  Scenario: Successful login with problem user credentials
    When I enter username 'problem_user' and password 'secret_sauce'
    And I click on the Login button
    Then I should be redirected to the home page

  Scenario: Unsuccessful login with invalid username
    When I enter username 'invalid_user' and password 'secret_sauce'
    And I click on the Login button
    Then I should see an error message

  Scenario: Unsuccessful login with invalid password
    When I enter username 'standard_user' and password 'invalid_password'
    And I click on the Login button
    Then I should see an error message

  Scenario: Unsuccessful login with both invalid username and password
    When I enter username 'invalid_user' and password 'invalid_password'
    And I click on the Login button
    Then I should see an error message