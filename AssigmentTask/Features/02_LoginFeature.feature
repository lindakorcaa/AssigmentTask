Feature: Login Feature

  @order
  Scenario: The user logs in successfully
    Given The user goes to Automation Exercise page
    When The user clicks Sign up or Login button in the homepage
    And The user fills out Email input field with "linda@linda.com" in the Sign up or Login page for the login process
    And The user fills out Password input field with "test1122" in the Sign up or Login page
    And The user clicks Login button in the Sign up or Login page
    Then The homepage is displayed

    
  @order
  Scenario Outline: The user tries to log in with invalid data
    Given The user goes to Automation Exercise page
    When The user clicks Sign up or Login button in the homepage
    And The user fills out the Email input field with "<email>" in the Sign up or Login page for the login process
    And The user fills out the Password input field with "<password>" in the Sign up or Login page
    And The user clicks Login button in the Sign up or Login page
    Then The "<error message>" is displayed

    Examples: 
    | email               | password | error message                        |
    | linda@linda1000.com | test1122 | your email or password is incorrect! |
    | linda@linda.com     | test     | your email or password is incorrect! |