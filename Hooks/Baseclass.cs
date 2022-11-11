using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace EcomWebsite.Hooks
{
    public class Baseclass
    {
       
            public IWebDriver? _driver;


            [BeforeScenario]
            public void Intialize()
            {
                _driver = new ChromeDriver();
//_driver.Manage().Window.Maximize();
          //  string currentUser = System.Environment.UserName; //read the Logged in user name
//ChromeOptions chroptions = new ChromeOptions();
         //   _driver.Navigate().GoToUrl("https://uat-cd-mny-ap-in.wsf-e-loreal.com/");
          //  chroptions.AddArguments("--noerrdialogs");
          //  chroptions.AddArguments(@"user-data-dir=C:\Users\" + currentUser + @"\AppData\Local\Google\Chrome\User Data");

            //chroptions.AddAdditionalCapability("useAutomationExtension", false);
           // chroptions.AddArgument("no-sandbox");
         //   _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chroptions, TimeSpan.FromMinutes(3));

            _driver.Manage().Window.Maximize();


        }

          //  [AfterScenario]
          //  public void CleanUp()
          //  {
          //      _driver.Quit();
          //  }
        }
    }

