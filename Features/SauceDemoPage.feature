Feature: SauceDemo website automation

  Scenario: User logs in to the SauceDemo website
    Given the user is on the login page
    When the user enters valid credentials
    And the user clicks on the login button
    Then the user should be redirected to the product page

  Scenario: User sorts products on the inventory page
    Given the user is on the inventory page
    When the user selects a sort option
    Then the products should be sorted accordingly

  Scenario: User proceeds to checkout from the cart page
    Given the user has added items to the cart
    And the user is on the cart page
    When the user clicks on the checkout button
    Then the user should be redirected to the checkout page