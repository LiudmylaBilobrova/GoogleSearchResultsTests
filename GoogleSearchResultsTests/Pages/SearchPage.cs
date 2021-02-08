using GoogleSearchResultsTests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleSearchResultsTests
{
    public class SearchPage
    {
        private readonly By inputSearchField;

        private IWebDriver driver;


        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            inputSearchField = By.XPath("//input[@class='gLFyf gsfi']");

        }
        public ResultPage Search(string text)
        {
            var searchField = driver.FindElement(inputSearchField);
            searchField.SendKeys(text);


            searchField.SendKeys(Keys.Return);

            return new ResultPage(driver);
        }
    }
}
