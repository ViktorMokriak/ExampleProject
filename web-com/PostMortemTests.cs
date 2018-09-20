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
    //IWebElement postMortemTileElement = driver.FindElement(By.CssSelector("#ui-panel-5-content .tile-detail"));
    
    public class PostMortemTests : TestBase
    
    {
        private enum PostMortemControls
        {
            PostMortemTile,
            CreatePostMortemButton,
            ValidateButton
        }

        private Dictionary<PostMortemControls, By> postMortemElements = new Dictionary<PostMortemControls, By>()
        {
            {PostMortemControls.PostMortemTile, By.CssSelector("img[src='./assets/images/tiles/post-mortem.png']")},
            {PostMortemControls.CreatePostMortemButton, By.CssSelector("p-button[ng-reflect-label='Create Post Mortem']")},
            {PostMortemControls.ValidateButton, By.CssSelector("p-button[label='Validate'] button")}
        };
       

        [Test]
        public void CheckPostMortemCreation()
        {
            NavigateToAllTilesPage();
            //Find and click Post Mortem Tile  
            IWebElement PostMortemTile = driver.FindElement(postMortemElements[PostMortemControls.PostMortemTile]);
            PostMortemTile.Click();            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Find and click Create Post Mortem Button
            IWebElement CreatePostMortemButton = driver.FindElement(postMortemElements[PostMortemControls.CreatePostMortemButton]);
            CreatePostMortemButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Check that Validate button is displayed 
            IWebElement ValidateButton = driver.FindElement(postMortemElements[PostMortemControls.ValidateButton]);
            CheckElementDispalyed(ValidateButton, nameof(ValidateButton));


        }

    }

}
