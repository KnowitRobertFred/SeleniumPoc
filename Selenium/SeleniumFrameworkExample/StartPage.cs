using System.Threading;
using OpenQA.Selenium;

namespace SeleniumFrameworkExample
{
    public class StartPage : BasePage
    {
        private const string PageUrl = "https://www.tele2.se/";

        public StartPage(IWebDriver webDriver) : base(webDriver)
        {
            NavigateTo();
        }

        public void NavigateTo()
        {
            NavigateToUrl(PageUrl);
        }

        public MobilePhonesPage OpenMobilePhonesPage()
        {
            Click(StartPageLocators.ShopMenuLink);
            Thread.Sleep(300); // Hårdkodad vänta för menyanimation.
            Click(StartPageLocators.MobilePhonesLink);

            return new MobilePhonesPage(Driver);
        }

        public void AssertIsAtWebPage()
        {
            // Assert.True(<Nuvarande sida är den förväntade.>);
        }
    }
}
