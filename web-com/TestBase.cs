using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace web_com
{
    // Test Class 
    [TestFixture]
    public abstract class TestBase
    {
        
            protected IWebDriver driver;
            protected string baseURL = "http://devuat/bullseyetelecom.webui.stg/";


        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var signInButton = driver.FindElement(By.CssSelector(".mat-toolbar .header-time .ui-button"));
            if (signInButton != null)
            {
                signInButton.Click();
            }
            else
            {
                Console.WriteLine("SignIn button is not displayed");
            }
        }

        [TearDown]
        public void EndTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                Console.WriteLine("Browser was not closed successfully");
            }

        }



        public IWebElement TryFindElement(IWebDriver driver, By element)
            {
                try
                {
                    return driver.FindElement(element);
                }
                catch
                {
                    return null;
                }
            }

            public void CheckElementDispalyed(IWebElement element, string control)
            {
                if (element != null)
                {
                    Console.WriteLine(control + " is displayed");
                }
                else
                {
                    Console.WriteLine(control + " is NOT displayed");
                }
            }

            public IWebElement ClickElement(IWebDriver driver, By element)
            {
                try
                {
                    return driver.FindElement(element);

                }
                catch
                {
                    return null;
                }

            }

        protected void NavigateToAllTilesPage()
        {
            //Find and click Main Menu Control
            IWebElement mainMenu = driver.FindElement(By.CssSelector(".example-toolbar.mat-toolbar.mat-toolbar-single-row>div>button"));
            mainMenu.Click();
            //Find and click All Tiles control in Main Menu 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement allTilesElement = driver.FindElement(By.XPath(".//*[@id='ui-panel-1-content']/div/div"));
            allTilesElement.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

             

    }

}
    
