using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Stylelabs.MQA.WebTesting.PageElements
{
    public class BasePageModel
    {
        private readonly IWebDriver _driver;
        public BasePageModel(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public IWebElement Find(By by)
        {
            return _driver.FindElement(by);
        }

        public void Hover(IWebElement btn)
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(btn).Build().Perform();
        }

        public void SetText(IWebElement txt, string text)
        {
            txt.SendKeys(text);
        }

        public void SelectByValue(IWebElement webElement, string value)
        {
            var selectElement = new SelectElement(webElement);

            selectElement.SelectByValue(value);
        }
    }
}