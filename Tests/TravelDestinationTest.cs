using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Stylelabs.MQA.WebTesting.PageElements;
using System;
using TechTalk.SpecFlow;

namespace Stylelabs.MQA.WebTesting.Tests
{
    [TestFixture]
    [Binding, Scope(Feature = "TravelDestination")]

    public class TravelDestinationTest
    {
        TravelDestination travelDestination;
        public IWebDriver webDriver;

        [BeforeScenario]
        public void Before()
        {
            string driverPath = @"C:\Users\dicleba";
            ChromeOptions chromeOptions = new ChromeOptions();
            
            webDriver = new ChromeDriver(driverPath, chromeOptions);

            travelDestination = new TravelDestination(webDriver);
        }


        [StepDefinition(@"I navigate to the Expedia website")]
        public void OpenHomePage()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(1));
            webDriver.Navigate().GoToUrl("https://www.expedia.com/");
        }

        [StepDefinition(@"I look for a flight and accommodation from '(.*)' to '(.*)'")]
        public void SetFlightAccommodation(string origin, string destination)
        {
            travelDestination.SetOrigin(origin);
            travelDestination.SetDestination(destination);
        }

        [StepDefinition(@"I choose dates in three months as '(.*)' and '(.*)'")]
        public void SetDate(string startDate, string endDate)
        {
            travelDestination.SetStartDate(startDate);
            travelDestination.SetEndDate(endDate);
        }
                
        [StepDefinition(@"I choose travelers as one adult and one child is '(.*)' years old")]
        public void SelectTravelersOption(string age)
        {
            travelDestination.ClickTraveler();
            travelDestination.ClickReduceAdultNumber();
            travelDestination.ClickBtnIncreaseChildNumber();
            travelDestination.SelectAge(age);
        }

        [StepDefinition(@"I click Search button")]
        public void SelectTravelersOption()
        {
            travelDestination.ClickSearch();
        }        

        [StepDefinition(@"The result page contains travel option for the chosen destination")]
        public void CheckChosenDestination()
        {
            travelDestination.CheckResult();
        }        
    }
}