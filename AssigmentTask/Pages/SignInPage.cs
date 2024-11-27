using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;

namespace AssigmentTask.Pages
{
    public class SignInPage : PageBase
    {
        

        By EmailInputField = By.Id("email");
        By PasswordInputField = By.Id("passwd");
        By SignInBtn = By.Id("SubmitLogin");
        By btn_Book_Now = By.XPath("//input[@value='Book now !']");

        public SignInPage(Drivers.DriverManager driver) : base(driver)
        {

        }

        
        public void fillOutEmailInputField(string email)
        {
            WaitUntilElementIsDisplayed(EmailInputField);
            getElement(EmailInputField).SendKeys(email);
        }

        public void fillOutPasswordInputField(string password)
        {
            WaitUntilElementIsDisplayed(PasswordInputField);
            getElement(PasswordInputField).SendKeys(password);
        }

        public void ClickSignInBtn()
        {
            WaitUntilElementIsClickable(SignInBtn);
            getElement(SignInBtn).Click();
        }

    }
}
