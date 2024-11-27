using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace AssigmentTask.Drivers
{
    public class DriverManager
    {
        private IWebDriver? driver ;

        public IWebDriver GetDriver()
        {
            if (driver == null)
            {

                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
                chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
                chromeOptions.AddUserProfilePreference("safebrowsing.enabled", "true");

                //chromeOptions.AddArguments("--incognito");

                    
                driver = new ChromeDriver(chromeOptions);
                driver.Manage().Window.Maximize();

            }    
            return driver;
        }
    }
}
