using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;

namespace AssigmentTask.Pages
{
    public class ProductsPage : PageBase
    {
        By MenCategory = By.CssSelector("[href *= 'Men']");
        By Price = By.TagName("h2");
        By AddToCartButton = By.ClassName("add-to-cart");
        By ViewCartButton = By.CssSelector("[href *= '/view_cart']");
        By CheckOutButton = By.ClassName("check_out");
        By TshirtSection = By.CssSelector("[href *= '/category_products/3']");
        By ProductInfo = By.ClassName("productinfo");


        public ProductsPage(Drivers.DriverManager driver) : base(driver) { }

        public void ClickMenCategoryButton()
        {
            WaitUntilElementIsClickable(MenCategory);
            scrollIntoView(MenCategory);
            getElement(MenCategory).Click();
        }

        public void ClickSection()
        {
            WaitUntilElementIsDisplayed(TshirtSection);
            scrollIntoView(TshirtSection);
            getElement(TshirtSection).Click();
        }

        public void ClickViewCartButton()
        {
            WaitUntilElementIsClickable(ViewCartButton);
            getElements(ViewCartButton).Last().Click();
        }

        public void ClickCheckOutButton()
        {
            WaitUntilElementIsClickable(CheckOutButton);
            scrollIntoView(CheckOutButton);
            getElement(CheckOutButton).Click();
        }

        public void AddCheapestItemToCart()
        {
            IList<IWebElement> productElements = getElements(ProductInfo);

            if (productElements.Count == 0)
            {
                throw new NoSuchElementException("No products found with the specified locator.");
            }

            IWebElement cheapestProduct = null;
            double cheapestPrice = double.MaxValue;

            foreach (var product in productElements)
            {
                try
                {
                    var priceElement = product.FindElement(Price);
                    double price = ParsePrice(priceElement.Text);

                    if (price < cheapestPrice)
                    {
                        cheapestPrice = price;
                        cheapestProduct = product;
                    }
                }
                catch (NoSuchElementException)
                {
                    continue;
                }
            }

            if (cheapestProduct == null)
            {
                throw new InvalidOperationException("No product with a valid price was found.");
            }

            var addToCartButton = cheapestProduct.FindElement(AddToCartButton);
            addToCartButton.Click();
        }

        private double ParsePrice(string priceText)
        {
            var cleanedText = new string(priceText.Where(c => char.IsDigit(c) || c == '.').ToArray());
            if (double.TryParse(cleanedText, out double price))
            {
                return price;
            }

            throw new FormatException($"Unable to parse price from text: '{priceText}'");
        }


    }
}
