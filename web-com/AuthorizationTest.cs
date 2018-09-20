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
    public class AuthorizationTest : TestBase
    {
        [Test]
        public void CheckAuthorization()
        {
          
            //Check that Sign Out button appears 
            IWebElement signOutButton = driver.FindElement(By.CssSelector("span.ui-button-text.ui-clickable"));
            bool status = signOutButton.Displayed;

            Assert.IsTrue(status, "Authorization was not successfull");
            Console.WriteLine("Authorization is successfull");

        }

    }
}
