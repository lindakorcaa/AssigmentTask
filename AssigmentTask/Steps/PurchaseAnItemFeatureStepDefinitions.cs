using AssigmentTask.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using AssigmentTask.Drivers;

namespace AssigmentTask.Steps
{
    [Binding]
    public class PurchaseAnItemFeatureStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        HomePage homePage;
        ProductsPage productsPage;
        PaymentPage paymentPage;
        IWebDriver driver;
        DriverManager driverManager;

        public PurchaseAnItemFeatureStepDefinitions(DriverManager driverManager)
        {
            this.driverManager = driverManager;
            homePage = new HomePage(driverManager);
            productsPage = new ProductsPage(driverManager);
            paymentPage = new PaymentPage(driverManager);
        }

        [When(@"The user clicks Products button from nav bar in Homepage")]
        public void WhenTheUserClicksProductsButtonFromNavBarInHomepage()
        {
            homePage.ClickProductsButton();
        }

        [When(@"The user selects Men category in the Products page")]
        public void WhenTheUserSelectsMenCategoryInTheProductsPage()
        {
            productsPage.ClickMenCategoryButton();
        }

        [When(@"The user selects Tshirts section in the Products page of Men category")]
        public void WhenTheUserSelectsTshirtsSectionInTheProductsPageOfMenCategory()
        {
            productsPage.ClickSection();
        }



        [When(@"The user selects the cheapest item in the Products page of Men category in Tshirts section")]
        public void WhenTheUserSelectsTheCheapestItemInTheProductsPageOfMenCategoryInTshirtsSection()
        {
            productsPage.AddCheapestItemToCart();
        }

        [When(@"The user clicks View Cart button in success modal")]
        public void WhenTheUserClicksViewCartButtonInSuccessModal()
        {
            productsPage.ClickViewCartButton();
        }

        [When(@"The user clicks Proceed to Checkout button in the View Cart page")]
        public void WhenTheUserClicksProceedToCheckoutButtonInTheViewCartPage()
        {
            productsPage.ClickCheckOutButton();
        }

        [When(@"The user clicks Place Order button in the Checkout page")]
        public void WhenTheUserClicksPlaceOrderButtonInTheCheckoutPage()
        {
            productsPage.ClickCheckOutButton();
        }

        [When(@"The user fills out Card Name input field with ""([^""]*)"" in the Payment page")]
        public void WhenTheUserFillsOutCardNameInputFieldWithInThePaymentPage(string cardName)
        {
            paymentPage.FillOutCardNameInputField(cardName);
        }

        [When(@"The user fills out Card Number input field with ""([^""]*)"" in the Payment page")]
        public void WhenTheUserFillsOutCardNumberInputFieldWithInThePaymentPage(string cardNumber)
        {
            paymentPage.FillOutCardNumberInputField(cardNumber);
        }

        [When(@"The user fills out CVC input field with ""([^""]*)"" in the Payment page")]
        public void WhenTheUserFillsOutCVCInputFieldWithInThePaymentPage(string cvc)
        {
            paymentPage.FillOutCVCInputField(cvc);
        }

        [When(@"The user fills out Expiry Month input field with ""([^""]*)"" in the Payment page")]
        public void WhenTheUserFillsOutExpiryMonthInputFieldWithInThePaymentPage(string expiryMonth)
        {
            paymentPage.FillOutExpiryMonthInputField(expiryMonth);
        }

        [When(@"The user fills out Expiry Year input field with ""([^""]*)"" in the Payment page")]
        public void WhenTheUserFillsOutExpiryYearInputFieldWithInThePaymentPage(string expiryYear)
        {
            paymentPage.FillOutExpiryYearInputField(expiryYear);
        }

        [When(@"The user clicks Pay and Confirm Order button in the Payment page")]
        public void WhenTheUserClicksPayAndConfirmOrderButtonInThePaymentPage()
        {
            paymentPage.ClickPayButton();
        }

        [When(@"The success message that the order has been placed is displayed")]
        public void WhenTheSuccessMessageThatTheOrderHasBeenPlacedIsDisplayed()
        {
            Assert.True(paymentPage.IsMessageDisplayed());
        }
    }
}
