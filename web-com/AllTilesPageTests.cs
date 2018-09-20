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
    public class AllTilesPageTests : TestBase

    {
        // New Comment
        [Test]
        public void CheckAllTilesPage()
        {
            IWebElement mainMenu = driver.FindElement(By.CssSelector(".example-toolbar.mat-toolbar.mat-toolbar-single-row>div>button"));
            mainMenu.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement allTiles = driver.FindElement(By.CssSelector("#ui-panel-35"));
            allTiles.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            var searchtTileElement = TryFindElement(driver, By.CssSelector("#ui-panel-3-content .tile-detail"));
            CheckElementDispalyed(searchtTileElement, nameof(searchtTileElement));

            var accountManagementTileElement = TryFindElement(driver, By.CssSelector("#ui-panel-4-content .tile-detail"));
            CheckElementDispalyed(accountManagementTileElement, nameof(accountManagementTileElement));

            var postMortemTileElement = TryFindElement(driver, By.CssSelector("#ui-panel-5-content .tile-detail"));
            CheckElementDispalyed(postMortemTileElement, nameof(postMortemTileElement));

            //IWebElement searchtTile = driver.FindElement(By.CssSelector("#ui-panel-3-content .tile-detail"));
            //CheckElementDispalyed(TryFindElement(driver, By.CssSelector("#ui-panel-3-content .tile-detail")));
            //IWebElement accountManagementTile = driver.FindElement(By.CssSelector("#ui-panel-16-content .tile-detail"));
            //IWebElement postMortemTile = driver.FindElement(By.CssSelector("#ui-panel-17-content .tile-detail"));

        }
    }
}
