using AssigmentTask.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using AssigmentTask.Drivers;

namespace AssigmentTask.Steps
{
    [Binding]
    public class AddToCartFeatureStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        HomePage homePage;
        SearchedItemPage searchedItemPage;
        SignInPage signInPage;
        IWebDriver driver;
        DriverManager driverManager;

        public AddToCartFeatureStepDefinitions(DriverManager driverManager)
        {
            this.driverManager = driverManager;
            homePage = new HomePage(driverManager);
            signInPage = new SignInPage(driverManager);
            searchedItemPage = new SearchedItemPage(driverManager);
        }

        [When(@"The user clicks Printed Chiffon Dress Button")]
        public void WhenTheUserClicksPrintedChiffonDressButton()
        {
            //searchedItemPage.ClickPrintedChiffonDressButton();
            searchedItemPage.ClickFirstItem();
        }


        [When(@"The user selects size ""([^""]*)""")]
        public void WhenTheUserSelectsSize(string m)
        {
            searchedItemPage.SelectSize(m);
          
        }

        [When(@"The user clicks Add To Cart button")]
        public void WhenTheUserClicksAddToCartButton()
        {
            searchedItemPage.clickAddToCartBtn();
        }

        [Then(@"Successful modal is displayed")]
        public void ThenSuccessfulModalIsDisplayed()
        {
            Assert.True(searchedItemPage.IsSuccessfulModalDisplayed());
        }
    }
}
