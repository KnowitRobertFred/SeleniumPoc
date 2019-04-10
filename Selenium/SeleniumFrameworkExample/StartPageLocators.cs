using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumFrameworkExample
{
    public class StartPageLocators
    {
        public static By ShopMenuLink => By.LinkText("Handla");
        public static By MobilePhonesLink => By.LinkText("Mobiltelefoner");
    }
}
