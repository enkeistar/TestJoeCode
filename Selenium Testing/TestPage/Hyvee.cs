using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace TestPage
{

    public class Hyvee
    {

        
        private IWebElement dropdownContainer;

        private static IWebDriver driver;

        public static Hyvee NavigateTo(IWebDriver webDriver)
        {
            driver = webDriver;
            driver.Navigate().GoToUrl("https://www.hy-vee.com/");
            var searchPage = new Hyvee();
            PageFactory.InitElements(driver, searchPage);

            return searchPage;
        }
        

        public void ClickSites()
        {
            dropdownContainer = driver.FindElement(By.CssSelector("div.dropdown.inline-block"));
            IWebElement sitesButton = dropdownContainer.FindElement(By.Id("dropdownMenu1"));
            sitesButton.Click();
        }

        public List<string> DisplayResults()
        {
            IWebElement list = dropdownContainer.FindElement(By.TagName("ul"));
            List<string> ret = new List<string>();
            foreach(var a in list.FindElements(By.TagName("a")))
            {
                ret.Add(a.GetAttribute("innerHTML"));
            }
            return ret;
        }

    }

}
