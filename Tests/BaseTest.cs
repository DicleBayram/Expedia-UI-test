using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Stylelabs.MQA.WebTesting.Tests
{
    public class BaseTest
    {
        public static void Main()
        {
            using (IWebDriver driver = new ChromeDriver(@"C:\Users\dicleba"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driver.Navigate().GoToUrl("https://www.expedia.com/");
            }
        }
    }
}
