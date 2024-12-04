using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;

namespace AssigmentTask.Pages
{
    public class LogInOrSignUpPage : PageBase
    {

        By NameInputField = By.Name("name");
        By EmailInputField = By.Name("email");
        By PasswordInputField = By.Name("password");
        By PasswordInputFieldInSignUpProcess = By.Id("password");
        By FirstNameInputField = By.Id("first_name");
        By LastNameInputField = By.Id("last_name");
        By AddressInputField = By.Id("address1");
        By CountryDropdown = By.Id("country");
        By StateInputField = By.Id("state");
        By CityInputField = By.Id("city");
        By ZipCodeInputField = By.Id("zipcode");
        By MobileNumberInputField = By.Id("mobile_number");
        By CreateAccountButton = By.CssSelector(".login-form .btn-default");
        By Heading2 = By.ClassName("title");
        By SubmitButton = By.ClassName("btn-default");
        By ContinueButton = By.ClassName("btn-primary");
        By ErrorMessage = By.CssSelector("form p");

        public LogInOrSignUpPage(Drivers.DriverManager driver) : base(driver) { }

        public void fillOutNameInputField(string name)
        {
            WaitUntilElementIsDisplayed(NameInputField);
            getElement(NameInputField).SendKeys(name);
        }

        public void fillOutEmailInputField(string email)
        {
            WaitUntilElementIsDisplayed(EmailInputField);
            getElement(EmailInputField).SendKeys(email);
        }
        public void fillOutEmailInputFieldInSignUpProcess(string email)
        {
            WaitUntilElementIsDisplayed(EmailInputField);
            getElements(EmailInputField).ElementAt(1).SendKeys(email);
        }

        public void fillOutPasswordInputField(string password)
        {
            WaitUntilElementIsDisplayed(PasswordInputField);
            getElement(PasswordInputField).SendKeys(password);
        }
        public void fillOutPasswordInputFieldInSignUpProcess(string password)
        {
            WaitUntilElementIsDisplayed(PasswordInputFieldInSignUpProcess);
            getElement(PasswordInputFieldInSignUpProcess).SendKeys(password);
        }

        public void fillOutFirstNameInputField(string firstName)
        {
            WaitUntilElementIsDisplayed(FirstNameInputField);
            getElement(FirstNameInputField).SendKeys(firstName);
        }

        public void fillOutLastNameInputField(string lastName)
        {
            WaitUntilElementIsDisplayed(LastNameInputField);
            getElement(LastNameInputField).SendKeys(lastName);
        }

        public void fillOutAddressInputField(string address)
        {
            WaitUntilElementIsDisplayed(AddressInputField);
            getElement(AddressInputField).SendKeys(address);
        }

        public void fillOutStateInputField(string state)
        {
            WaitUntilElementIsDisplayed(StateInputField);
            getElement(StateInputField).SendKeys(state);
        }

        public void fillOutCityInputField(string city)
        {
            WaitUntilElementIsDisplayed(CityInputField);
            getElement(CityInputField).SendKeys(city);
        }

        public void fillOutZipCodeInputField(string zipCode)
        {
            WaitUntilElementIsDisplayed(ZipCodeInputField);
            getElement(ZipCodeInputField).SendKeys(zipCode);
        }

        public void fillOutMobileNumberInputField(string mobileNumber)
        {
            WaitUntilElementIsDisplayed(MobileNumberInputField);
            getElement(MobileNumberInputField).SendKeys(mobileNumber);
        }

        public void ClickSignupButton()
        {
            WaitUntilElementIsClickable(SubmitButton);
            getElements(SubmitButton).ElementAt(1).Click();
        }

        public void SelectUnitedStatesCountry(string country)
        {
            WaitUntilElementIsClickable(CountryDropdown);
            getOptionFromADropDownByText(country).Click();
        }

        public void ClickCreateAccountButton()
        {
            WaitUntilElementIsClickable(CreateAccountButton);
            getElement(CreateAccountButton).Click();
        }

        public bool IsMessageDisplayed(string message)
        {
            return getElement(Heading2).Text.ToLower().Contains(message);
        }

        public void ClickContinueButton()
        {
            WaitUntilElementIsClickable(ContinueButton);
            getElement(ContinueButton).Click();
        }

        public bool IsErrorMessageDisplayed(string errorMessage)
        {
            return getElements(ErrorMessage).First().Text.ToLower().Contains(errorMessage);
        }

        public void ClickLoginButton()
        {
            WaitUntilElementIsClickable(SubmitButton);
            getElement(SubmitButton).Click();
        }

        public bool IsErrorMessageDisplayedInLoginProcess(string errorMessage)
        {
            return getElements(ErrorMessage).First().Text.ToLower().Contains(errorMessage);
        }
    }
}
