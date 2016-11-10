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
        [FindsBy(How = How.Id, Using = "q")]
        private IWebElement searchBar;

    }
}
