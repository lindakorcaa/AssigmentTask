Feature: Add to Cart Feature

  @order
  Scenario: Search for an item
    Given The user goes to Automation Practice page
    When The user clicks Search button in the homepage
    And The user fills out search input field with "Printed Chiffon Dress"
    And The user clicks enter
    And The user clicks Printed Chiffon Dress Button
    And The user selects size "M"
    And The user clicks Add To Cart button
    Then Successful modal is displayed

