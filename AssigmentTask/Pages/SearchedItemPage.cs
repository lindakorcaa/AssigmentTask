using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;

namespace AssigmentTask.Pages
{
    public class SearchedItemPage : PageBase
    {
        

        By SizeButton = By.Id("group_1");
        By AddToCartButton = By.CssSelector("#add_to_cart .exclusive");
        By ItemsName = By.CssSelector(".product-container .product-name");
        By SearchedKeyword = By.ClassName("lighter");
        By Headings2 = By.TagName("h2");
        By InStockLabel = By.ClassName("label-success");
        By SendToAFriendButton = By.ClassName("sendtofriend");
        By WrapResetImages = By.Id("wrapResetImages");
        public SearchedItemPage(Drivers.DriverManager driver) : base(driver)
        {

        }

        public bool SearchedKeywordDisplayed(string keyword)
        {
            WaitUntilElementIsDisplayed(SearchedKeyword);
            string a = getElement(SearchedKeyword).Text.ToLower();
            return a.Contains(keyword);
        }

        public void ClickFirstItem()
        {
            WaitUntilElementIsClickable(ItemsName);
            getElement(ItemsName).Click();
        }

        public void ScrollIntoSizeSelection()
        {
            scrollIntoView(SizeButton);
        }
        public void ScrollIntoWrapResetImages()
        {
            scrollIntoView(WrapResetImages);
        }

        public void SelectSize(string size)
        {
            ScrollIntoSizeSelection();
            getOptionFromADropDownByText(size).Click();
        }
        
        public void clickAddToCartBtn()
        {
           RefreshThePage();
            ScrollIntoWrapResetImages();
            WaitUntilElementIsDisplayed(InStockLabel);
            getElement(AddToCartButton).Click();
        }

        public bool IsSuccessfulModalDisplayed()
        {
            WaitUntilElementIsDisplayed(Headings2);
            return getElements(Headings2).First().Text.Contains("Product successfully added to your shopping cart");
        }

    }
}
