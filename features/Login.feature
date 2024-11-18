Feature: Swag Labs Login

  As a Swag Labs user
  I want to be able to log in with valid credentials
  So that I can access the web application

  Background:
    Given The Swag Labs website is opened

  Scenario: Verify successful login with valid credentials
    When I enter username 'standard_user' and password 'secret_sauce'
    And I click on the Login button
    Then I should be successfully logged in and directed to the home page

  Scenario: Verify successful login with different valid credentials
    When I enter username 'problem_user' and password 'secret_sauce'
    And I click on the Login button
    Then I should be successfully logged in and directed to the home page

  Scenario: Verify login with invalid username
    When I enter username 'invalid_user' and password 'secret_sauce'
    And I click on the Login button
    Then I should not be able to log in and an error message should be displayed

  Scenario: Verify login with invalid password
    When I enter username 'standard_user' and password 'invalid_password'
    And I click on the Login button
    Then I should not be able to log in and an error message should be displayed

  Scenario: Verify login with both invalid username and password
    When I enter username 'invalid_user' and password 'invalid_password'
    And I click on the Login button
    Then I should not be able to log in and an error message should be displayed