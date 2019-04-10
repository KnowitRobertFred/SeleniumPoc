using OpenQA.Selenium;

namespace SeleniumFrameworkExample
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }
        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        protected void Click<T>(T objectToClick)
        {
            var webElement = objectToClick is IWebElement
                ? objectToClick as IWebElement
                : GetWebElement(objectToClick as By);

            webElement.Click();
        }

        protected IWebElement GetWebElement(By locator)
        {
            var webElement = Driver.FindElement(locator);

            return webElement;
        }

        protected void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}
