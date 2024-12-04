Feature: Sign up Feature

  @order
  Scenario: The user signs up successfully
    Given The user goes to Automation Exercise page
    When The user clicks Sign up or Login button in the homepage
    And The user fills out Name input field with "Linda" in the Sign up or Login page
    And The user fills out Email input field with "linda502@linda.com" in the Sign up or Login page
    And The user clicks Signup button in the Sign up or Login page
    And The user fills out Password input field with "test1122" in the Sign up page
    And The user fills out First Name input field with "Linda" in the Sign up page
    And The user fills out Last Name input field with "Korca" in the Sign up page
    And The user fills out Address input field with "Martiret e Gjilanit 15" in the Sign up page
    And The user selects "United States" option from the Country dropdown in the Sign up page
    And The user fills out State input field with "Kosovo" in the Sign up page
    And The user fills out City input field with "Gjilan" in the Sign up page
    And The user fills out Zipcode input field with "60000" in the Sign up page
    And The user fills out Mobile number input field with "049123123" in the Sign up page
    And The user clicks Create Account Button in the Sign up page
    Then The message that the account is created is displayed

    @order
  Scenario: The user signs up with an already existing email
    Given The user goes to Automation Exercise page
    When The user clicks Sign up or Login button in the homepage
    And The user fills out Name input field with "Linda" in the Sign up or Login page
    And The user fills out Email input field with "linda@linda.com" in the Sign up or Login page
    And The user clicks Signup button in the Sign up or Login page
    Then The error message "email address already exist!" is displayed in the Sign up or Login page