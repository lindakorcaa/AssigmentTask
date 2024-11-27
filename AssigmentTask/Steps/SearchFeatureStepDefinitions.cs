using AssigmentTask.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using AssigmentTask.Drivers;

namespace AssigmentTask.Steps
{
    [Binding]
    public class SearchFeatureStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        HomePage homePage;
        SearchedItemPage searchedItemPage;
        SignInPage signInPage;
        IWebDriver driver;
        DriverManager driverManager;

        public SearchFeatureStepDefinitions(DriverManager driverManager)
        {
            this.driverManager = driverManager;
            homePage = new HomePage(driverManager);
            signInPage = new SignInPage(driverManager);
            searchedItemPage = new SearchedItemPage(driverManager);
        }

        [When(@"The user clicks Search button in the homepage")]
        public void WhenTheUserClicksSearchButtonInTheHomepage()
        {
            homePage.ClickSearchButton();
        }

        [When(@"The user fills out search input field with ""([^""]*)""")]
        public void WhenTheUserFillsOutSearchInputFieldWith(string dress)
        {
            homePage.fillOutSearchInputField(dress);
        }

        [When(@"The user clicks enter")]
        public void WhenTheUserClicksEnter()
        {
            homePage.PressEnter();
        }

        [Then(@"All items that contain ""([^""]*)"" are displayed")]
        public void ThenAllItemsThatContainAreDisplayed(string dress)
        {
            
            Assert.True(searchedItemPage.SearchedKeywordDisplayed(dress));
        }
    }
}
