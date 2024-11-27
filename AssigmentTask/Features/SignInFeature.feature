Feature: Sign in Feature

  @order
  Scenario: Sign in with an already created account
    Given The user goes to Automation Practice page
    When The user clicks Sign in button in the homepage
    And The user fills out email input field with "linda.korcaa@gmail.com" in the Sign in page
    And The user fills out password input field with "test1122" in the Sign in page
    And The user clicks Sign in button in the Sign in page
    Then The user is redirected to My account page
