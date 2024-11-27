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
        

        By SignInButton = By.ClassName("login");
        By SearchButton = By.ClassName("search_query");
        By input_Number_Of_Nights = By.XPath("//input[@id='to-place']");
        By btn_Book_Now = By.XPath("//input[@value='Book now !']");

        public HomePage(Drivers.DriverManager driver) : base(driver)
        {

        }

        
        public void ClickSignInButton()
        {
            WaitUntilElementIsDisplayed(SignInButton);
            getElement(SignInButton).Click();
        }

        public void ClickSearchButton()
        {
            WaitUntilElementIsClickable(SearchButton);
            getElement(SearchButton).Click();
        }

        public void fillOutSearchInputField(string keyword)
        {
            WaitUntilElementIsDisplayed(SearchButton);
            getElement(SearchButton).SendKeys(keyword);
        }

        public void PressEnter()
        {
            getElement(SearchButton).SendKeys(Keys.Enter);
        }
    }
}
