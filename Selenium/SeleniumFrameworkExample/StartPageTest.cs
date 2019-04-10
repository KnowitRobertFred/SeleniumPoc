using System;
using System.Threading;
using NUnit.Framework;

namespace SeleniumFrameworkExample
{
    public class StartPageTest : TestBase
    {
        [Test]
        [Category("System")]
        public void Clicking_mobile_grid_link_shall_open_mobile_grid()
        {
            var startPage = new StartPage(WebDriver);
            var mobilePhonesPage = startPage.OpenMobilePhonesPage();
            Thread.Sleep(TimeSpan.FromSeconds(5)); // Bara för att visa att man är på rätt sida.
        }
    }
}
