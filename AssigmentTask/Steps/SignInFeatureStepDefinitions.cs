using AssigmentTask.Drivers;
using AssigmentTask.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Assigment.Steps
{

    [Binding]
    public class SignInFeatureStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        HomePage homePage;
        SearchedItemPage searchedItemPage;
        SignInPage signInPage;
        IWebDriver driver;
        DriverManager driverManager;

        public SignInFeatureStepDefinitions(DriverManager driverManager)
        {
            this.driverManager = driverManager;
            homePage = new HomePage(driverManager);
            signInPage = new SignInPage(driverManager);
            searchedItemPage = new SearchedItemPage(driverManager);
        }

        [Given(@"The user goes to Automation Practice page")]
        public void GivenTheUserGoesToAutomationPracticePage()
        {
            driver = driverManager.GetDriver();
            driver.Url = "http://www.automationpractice.pl/index.php";
        }

        [When(@"The user clicks Sign in button in the homepage")]
        public void WhenTheUserClicksSignInButtonInTheHomepage()
        {
            homePage.ClickSignInButton();
        }

        [When(@"The user fills out email input field with ""([^""]*)"" in the Sign in page")]
        public void WhenTheUserFillsOutEmailInputFieldWithInTheSignInPage(string email)
        {
            signInPage.fillOutEmailInputField(email);
        }

        [When(@"The user fills out password input field with ""([^""]*)"" in the Sign in page")]
        public void WhenTheUserFillsOutPasswordInputFieldWithInTheSignInPage(string password)
        {
            signInPage.fillOutPasswordInputField(password);
        }

        [When(@"The user clicks Sign in button in the Sign in page")]
        public void WhenTheUserClicksSignInButtonInTheSignInPage()
        {
            signInPage.ClickSignInBtn();
        }

        [Then(@"The user is redirected to My account page")]
        public void ThenTheUserIsRedirectedToMyAccountPage()
        {
            Assert.True(driver.Url.Contains("controller=my-account"));
        }
    }
}
