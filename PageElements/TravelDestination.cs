using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;

namespace Stylelabs.MQA.WebTesting.PageElements
{
    [Binding]
    [TestFixture]

    public class TravelDestination : BasePageModel
    {
        #region
        [FindsBy(How = How.XPath, Using = "//*[@id='package-origin-hp-package']")]
        public IWebElement txtOrigin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='package-destination-hp-package']")]
        public IWebElement txtDestination { get; set; }

        [FindsBy(How = How.Id, Using = "package-departing-hp-package")]
        public IWebElement txtDeparting { get; set; }    

        [FindsBy(How = How.Id, Using = "package-returning-hp-package")]
        public IWebElement txtReturning { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='traveler-selector-hp-package']/div/ul/li/button")]
        public IWebElement btnTraveler { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='traveler-selector-hp-package']/div/ul/li/div/div/div[1]/div[2]/div[4]/button")]
        public IWebElement btnReduceAdultNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='traveler-selector-hp-package']/div/ul/li/div/div/div[1]/div[3]/div[1]/div[4]/button")]
        public IWebElement btnIncreaseChildNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='traveler-selector-hp-package']/div/ul/li/div/div/div[1]/div[3]/div[2]/label[1]/select")]
        public IWebElement btnAge { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='traveler-selector-hp-package']/div/ul/li/div/div/div[1]/div[3]/div[2]/label[1]/select")]
        //public IList<IWebElement> lblAgeOption { get; set; }
        public IWebElement lblAgeOption { get; set; }

        [FindsBy(How = How.Id, Using = "search-button-hp-package")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchWizard']/div[2]/div[1]/div/div[2]/div[1]/button")]
        public IWebElement btnSearchWizard { get; set; }

        string checkOrigin;

        public TravelDestination(IWebDriver driver) : base(driver)
        {
        }
        #endregion

        #region
        public void SetOrigin(string origin)
        {
            SetText(txtOrigin, origin);
            txtOrigin.SendKeys(Keys.Tab);
            checkOrigin = origin;
        }

        public void SetDestination(string destination)
        {
            SetText(txtDestination, destination);
            txtDestination.SendKeys(Keys.Tab);
        }
               
        public void SetStartDate(string startDate)
        {
            txtDeparting.SendKeys(Keys.Tab);
            SetText(txtDeparting, startDate);      
        }

        public void SetEndDate(string endDate)
        {
            for (int i = 0; i <= 10; i++)
            {
                txtReturning.SendKeys(Keys.Backspace);
            }            
            txtReturning.Clear();
            SetText(txtReturning, endDate);
        }

        public void ClickTraveler()
        {
            btnTraveler.Click();
        }

        public void ClickReduceAdultNumber()
        {
            btnReduceAdultNumber.Click();
        }

        public void ClickBtnIncreaseChildNumber()
        {
            btnIncreaseChildNumber.Click();
        }

        public void SelectAge(string age)
        {
            SelectByValue(lblAgeOption, age);
            
        }

        public void ClickSearch()
        {
            btnSearch.Click();
        }

        public void CheckResult()
        {
            bool contain = btnSearchWizard.Text.Contains(checkOrigin);
            Assert.IsTrue(contain);
        }
        #endregion
    }
}
