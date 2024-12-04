using System;
using TechTalk.SpecFlow;
using AssigmentTask.Drivers;
using AssigmentTask.Pages;
using OpenQA.Selenium;
using Xunit.Sdk;


namespace AssigmentTask.Steps
{
    [Binding]
    public class LoginFeatureStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        HomePage homePage;
        LogInOrSignUpPage logInOrSignUpPage;
        IWebDriver driver;
        DriverManager driverManager;

        public LoginFeatureStepDefinitions(DriverManager driverManager)
        {
            this.driverManager = driverManager;
            homePage = new HomePage(driverManager);
            logInOrSignUpPage = new LogInOrSignUpPage(driverManager);
        }

        [When(@"The user fills out Email input field with ""([^""]*)"" in the Sign up or Login page for the login process")]
        public void WhenTheUserFillsOutEmailInputFieldWithInTheSignUpOrLoginPageForTheLoginProcess(string email)
        {
            logInOrSignUpPage.fillOutEmailInputField(email);
        }


        [When(@"The user fills out Password input field with ""([^""]*)"" in the Sign up or Login page")]
        public void WhenTheUserFillsOutPasswordInputFieldWithInTheSignUpOrLoginPage(string password)
        {
            logInOrSignUpPage.fillOutPasswordInputField(password);
        }

        [When(@"The user clicks Login button in the Sign up or Login page")]
        public void WhenTheUserClicksLoginButtonInTheSignUpOrLoginPage()
        {
            logInOrSignUpPage.ClickLoginButton();
        }

        [Then(@"The homepage is displayed")]
        public void ThenTheHomepageIsDisplayed()
        {
            Assert.True(homePage.IsUserLoggedIn());
        }

       

        [When(@"The user fills out the Email input field with ""([^""]*)"" in the Sign up or Login page for the login process")]
        public void WhenTheUserFillsOutTheEmailInputFieldWithInTheSignUpOrLoginPageForTheLoginProcess(string email)
        {
            logInOrSignUpPage.fillOutEmailInputField(email);
        }

        [When(@"The user fills out the Password input field with ""([^""]*)"" in the Sign up or Login page")]
        public void WhenTheUserFillsOutThePasswordInputFieldWithInTheSignUpOrLoginPage(string password)
        {
            logInOrSignUpPage.fillOutPasswordInputField(password);
        }

        [Then(@"The ""([^""]*)"" is displayed")]
        public void ThenTheIsDisplayed(string errorMessage)
        {
            Assert.True(logInOrSignUpPage.IsErrorMessageDisplayedInLoginProcess(errorMessage));
        }

    }
}
