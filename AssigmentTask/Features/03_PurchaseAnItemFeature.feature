Feature: Purchase an item Feature

  @order
  Scenario: Add items to the cart. The item should be the one with the lowest price in the "Men" category, section "Tshirts".
    Given The user goes to Automation Exercise page
    When The user clicks Sign up or Login button in the homepage
    And The user fills out Email input field with "linda@linda.com" in the Sign up or Login page for the login process
    And The user fills out Password input field with "test1122" in the Sign up or Login page
    And The user clicks Login button in the Sign up or Login page
    And The user clicks Products button from nav bar in Homepage
    And The user selects Men category in the Products page
    And The user selects Tshirts section in the Products page of Men category
    And The user selects the cheapest item in the Products page of Men category in Tshirts section
    And The user clicks View Cart button in success modal
    And The user clicks Proceed to Checkout button in the View Cart page
    And The user clicks Place Order button in the Checkout page
    And The user fills out Card Name input field with "Linda Korca" in the Payment page
    And The user fills out Card Number input field with "4242424242424242" in the Payment page
    And The user fills out CVC input field with "123" in the Payment page
    And The user fills out Expiry Month input field with "12" in the Payment page
    And The user fills out Expiry Year input field with "2030" in the Payment page
    And The user clicks Pay and Confirm Order button in the Payment page
    And The success message that the order has been placed is displayed
