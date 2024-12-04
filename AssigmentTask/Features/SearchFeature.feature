Feature: Search Feature

  @order
  Scenario: Search for an item
    Given The user goes to Automation Practice page
    When The user clicks Search button in the homepage
    And The user fills out search input field with "dress"
    And The user clicks enter
    Then All items that contain "dress" are displayed
