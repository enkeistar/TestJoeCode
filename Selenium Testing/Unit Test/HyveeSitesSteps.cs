using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

namespace Unit_Test
{
    [Binding]
    public class HyveeSitesSteps
    {
        private Hyvee hyPage;
        private IWebDriver driver;

        [BeforeScenario()]
        public void start()
        {
            driver = new FirefoxDriver();
        }

        [AfterScenario()]
        public void tearDown()
        {
            driver.Quit();
        }

        [Given(@"I want to find different Hy-Vee sites")]
        public void GivenIWantToFindDifferentHy_VeeSites()
        {
            hyPage = Hyvee.NavigateTo(driver);
        }
        
        [When(@"I click on the sites button on the Hy-Vee main page")]
        public void WhenIClickOnTheSitesButtonOnTheHy_VeeMainPage()
        {
            hyPage.ClickSites();
        }
        
        [Then(@"four different sites will be displayed to me")]
        public void ThenFourDifferentSitesWillBeDisplayedToMe()
        {
            var ret = hyPage.DisplayResults();
            Debug.WriteLine("Found following sites:");
            foreach(string s in ret)
            {
                Debug.WriteLine(s);
            }
            Assert.IsTrue(ret.Count == 4);
        }
    }
}
