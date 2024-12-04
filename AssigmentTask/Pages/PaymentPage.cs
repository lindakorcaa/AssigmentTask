using AssigmentTask.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentTask.Pages
{
    internal class PaymentPage : PageBase
    {
        By CardNameInputField = By.Name("name_on_card");
        By CardNumberInputField = By.ClassName("card-number");
        By CVCInputField = By.ClassName("card-cvc");
        By ExpiryMonthInputField = By.ClassName("card-expiry-month");
        By ExpiryYearInputField = By.ClassName("card-expiry-year");
        By PayButton = By.ClassName("submit-button");
        By Heading2 = By.ClassName("title");


        public PaymentPage(Drivers.DriverManager driver) : base(driver) { }

        public void FillOutCardNameInputField(string CardName)
        {
            WaitUntilElementIsDisplayed(CardNameInputField);
            getElement(CardNameInputField).SendKeys(CardName);
        }

        public void FillOutCardNumberInputField(string CardNumber)
        {
            getElement(CardNumberInputField).SendKeys(CardNumber);
        }

        public void FillOutCVCInputField(string CVCInput)
        {
            getElement(CVCInputField).SendKeys(CVCInput);
        }

        public void FillOutExpiryMonthInputField(string ExpiryMonthInput)
        {
            getElement(ExpiryMonthInputField).SendKeys(ExpiryMonthInput);
        }

        public void FillOutExpiryYearInputField(string ExpiryYearInput)
        {
            getElement(ExpiryYearInputField).SendKeys(ExpiryYearInput);
        }

        public void ClickPayButton()
        {
            WaitUntilElementIsClickable(PayButton);
            getElement(PayButton).Click();
        }

        public bool IsMessageDisplayed()
        {
            WaitUntilElementIsDisplayed(Heading2);
            return getElement(Heading2).Text.ToLower().Contains("order placed!");
        }

    }
}
