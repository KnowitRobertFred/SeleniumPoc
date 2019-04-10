using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFrameworkExample
{
    public class TestBase
    {
        public IWebDriver WebDriver { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            WebDriver = new ChromeDriver();
        }

        [SetUp]
        public void SetUp()
        {
            // No implemented code.
        }

        [TearDown]
        public void TearDown()
        {
            // No implented code.
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriver.Quit();
        }
    }
}
