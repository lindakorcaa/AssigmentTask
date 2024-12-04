using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;

namespace AssigmentTask.Pages
{
    public class HomePage : PageBase
    {
        By LogInOrSignUpButton = By.ClassName("fa-lock");
        By DeleteAccountButton = By.ClassName("fa-trash-o");
        By ProductsButton = By.ClassName("card_travel");


        public HomePage(Drivers.DriverManager driver) : base(driver) { }

        public void ClickLogInOrSignUpButton()
        {
            WaitUntilElementIsClickable(LogInOrSignUpButton);
            getElement(LogInOrSignUpButton).Click();
        }

        public bool IsUserLoggedIn()
        {
            WaitUntilElementIsClickable(DeleteAccountButton);
            return getElement(DeleteAccountButton).Displayed;
        }

        public void ClickProductsButton()
        {
            WaitUntilElementIsClickable(ProductsButton);
            getElement(ProductsButton).Click();
        }


    }
}
