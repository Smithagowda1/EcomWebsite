using EcomWebsite.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace EcomWebsite.Steps
{
    [Binding]
    public sealed class LoignStep
    {

        [Given(@"I open the URL ""(.*)""")]
        public void GivenIOpenTheURL(string url)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

        }

    }
}
