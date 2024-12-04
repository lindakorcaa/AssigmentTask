using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using SeleniumExtras.WaitHelpers;
using AssigmentTask.Drivers;
using OpenQA.Selenium.Interactions;
using ICSharpCode.SharpZipLib.Core;


namespace AssigmentTask.Pages
{
    public class PageBase
    {
        IWebDriver driver;

        public PageBase(Drivers.DriverManager driver)
        {
            this.driver = driver.GetDriver();
        }


        #region Get Elements
        public IWebElement getElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(7));
            return wait.Until(ExpectedConditions.ElementExists(by));
        }

       

        public IWebElement getOptionFromADropDownByText(String elementValue)
        {
            foreach(WebElement element in getElements(By.TagName("option")))
            {
                if(element.Text.Equals(elementValue)) 
                    return element;
            }
            return getElement(By.CssSelector("[value='" + elementValue + "']"));
        }


        public IWebElement GetElementFromListByText(By locator, string elementValue)
        {
            IList<IWebElement> elements = getElements(locator);

            foreach (var element in elements)
            {
                if (element.Text.Equals(elementValue, StringComparison.OrdinalIgnoreCase))
                {
                    return element;
                }
            }
            throw new NoSuchElementException($"No element with text '{elementValue}' was found.");
        }


        public IList<IWebElement> getElements(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            return wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
        }
        #endregion

        #region Waits
       

        public void WaitUntilElementIsClickable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public void WaitUntilElementIsDisplayed(By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementExists(locator));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
        #endregion

       

        #region Scrolls
        public void scrollIntoView(By by)
        {
            IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
            js.ExecuteScript("arguments[0].scrollIntoView(false);", getElement(by));
        }
        #endregion



        public void RefreshThePage()
        {
            driver.Navigate().Refresh();
        }

        public string ScreenshotAsBase64String()
        {
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            return Convert.ToBase64String (screenshot.AsByteArray);
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
