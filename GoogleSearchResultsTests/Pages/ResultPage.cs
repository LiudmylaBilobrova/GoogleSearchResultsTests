using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleSearchResultsTests.Pages
{
    public class ResultPage
    {
        private readonly By countElement;
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            countElement = By.XPath("//h3[@class='LC20lb DKV0Md']");
        }
        public void CheckResultContains10Results()
        {
            var searchResults = driver.FindElements(countElement);
            Assert.AreEqual(10, searchResults.Count);
        }
    }
}
