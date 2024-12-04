using AssigmentTask.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using AssigmentTask.Drivers;

namespace AssigmentTask.Steps
{
    [Binding]
    public class SignUpFeatureStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        HomePage homePage;
        LogInOrSignUpPage logInOrSignUpPage;
        IWebDriver driver;
        DriverManager driverManager;

        public SignUpFeatureStepDefinitions(DriverManager driverManager)
        {
            this.driverManager = driverManager;
            homePage = new HomePage(driverManager);
            logInOrSignUpPage = new LogInOrSignUpPage(driverManager);
        }

        [Given(@"The user goes to Automation Exercise page")]
        public void GivenTheUserGoesToAutomationExercisePage()
        {
            driver = driverManager.GetDriver();
            driver.Url = "https://automationexercise.com/";
        }

        [When(@"The user clicks Sign up or Login button in the homepage")]
        public void WhenTheUserClicksSignUpOrLoginButtonInTheHomepage()
        {
            homePage.ClickLogInOrSignUpButton();
        }

        [When(@"The user fills out Name input field with ""([^""]*)"" in the Sign up or Login page")]
        public void WhenTheUserFillsOutNameInputFieldWithInTheSignUpOrLoginPage(string name)
        {
            logInOrSignUpPage.fillOutNameInputField(name);
        }

        [When(@"The user fills out Email input field with ""([^""]*)"" in the Sign up or Login page")]
        public void WhenTheUserFillsOutEmailInputFieldWithInTheSignUpOrLoginPage(string email)
        {
            logInOrSignUpPage.fillOutEmailInputFieldInSignUpProcess(email);
        }

        [When(@"The user clicks Signup button in the Sign up or Login page")]
        public void WhenTheUserClicksSignupButtonInTheSignUpOrLoginPage()
        {
            logInOrSignUpPage.ClickSignupButton();
        }

        [When(@"The user fills out Password input field with ""([^""]*)"" in the Sign up page")]
        public void WhenTheUserFillsOutPasswordInputFieldWithInTheSignUpPage(string password)
        {
            logInOrSignUpPage.fillOutPasswordInputFieldInSignUpProcess(password);
        }

        [When(@"The user fills out First Name input field with ""([^""]*)"" in the Sign up page")]
        public void WhenTheUserFillsOutFirstNameInputFieldWithInTheSignUpPage(string firstName)
        {
            logInOrSignUpPage.fillOutFirstNameInputField(firstName);
        }

        [When(@"The user fills out Last Name input field with ""([^""]*)"" in the Sign up page")]
        public void WhenTheUserFillsOutLastNameInputFieldWithInTheSignUpPage(string lastName)
        {
            logInOrSignUpPage.fillOutLastNameInputField(lastName);
        }

        [When(@"The user fills out Address input field with ""([^""]*)"" in the Sign up page")]
        public void WhenTheUserFillsOutAddressInputFieldWithInTheSignUpPage(string address)
        {
            logInOrSignUpPage.fillOutAddressInputField(address);
        }

        [When(@"The user selects Country from the Country dropdown list in the Sign up page")]
        public void WhenTheUserSelectsCountryFromTheCountryDropdownListInTheSignUpPage()
        {
            throw new PendingStepException();
        }

        [When(@"The user fills out State input field with ""([^""]*)"" in the Sign up page")]
        public void WhenTheUserFillsOutStateInputFieldWithInTheSignUpPage(string state)
        {
            logInOrSignUpPage.fillOutStateInputField(state);
        }

        [When(@"The user fills out City input field with ""([^""]*)"" in the Sign up page")]
        public void WhenTheUserFillsOutCityInputFieldWithInTheSignUpPage(string city)
        {
            logInOrSignUpPage.fillOutCityInputField(city);
        }

        [When(@"The user fills out Zipcode input field with ""([^""]*)"" in the Sign up page")]
        public void WhenTheUserFillsOutZipcodeInputFieldWithInTheSignUpPage(string zipcode)
        {
            logInOrSignUpPage.fillOutZipCodeInputField(zipcode);
        }

        [When(@"The user fills out Mobile number input field with ""([^""]*)"" in the Sign up page")]
        public void WhenTheUserFillsOutMobileNumberInputFieldWithInTheSignUpPage(string mobileNumber)
        {
            logInOrSignUpPage.fillOutMobileNumberInputField(mobileNumber);
        }

        [When(@"The user selects ""([^""]*)"" option from the Country dropdown in the Sign up page")]
        public void WhenTheUserSelectsOptionFromTheCountryDropdownInTheSignUpPage(string country)
        {
            logInOrSignUpPage.SelectUnitedStatesCountry(country);
        }


        [When(@"The user clicks Create Account Button in the Sign up page")]
        public void WhenTheUserClicksCreateAccountButtonInTheSignUpPage()
        {
            logInOrSignUpPage.ClickCreateAccountButton();
        }

        [Then(@"The message that the account is created is displayed")]
        public void ThenTheMessageThatTheAccountIsCreatedIsDisplayed()
        {
            Assert.True(logInOrSignUpPage.IsMessageDisplayed("account created!"));
            logInOrSignUpPage.ClickContinueButton();
        }

        [Then(@"The error message ""([^""]*)"" is displayed in the Sign up or Login page")]
        public void ThenTheErrorMessageIsDisplayedInTheSignUpOrLoginPage(string errorMessage)
        {
            Assert.True(logInOrSignUpPage.IsErrorMessageDisplayed(errorMessage));
        }

    }
}
