using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace GoogleSearchResultsTests
{
    public class GoogleSearchResults
    {
        private IWebDriver driver;

        private readonly By inputSearchField = By.XPath("//input[@class='gLFyf gsfi']");
        private const string searchText = "Who the fuck is Alice";
        private readonly By countElement = By.XPath("//h3[@class='LC20lb DKV0Md']");

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void SearchResultInspection()
        {

            System.Threading.Thread.Sleep(5000);

            var searchField = driver.FindElement(inputSearchField);
            searchField.SendKeys(searchText);

            //System.Threading.Thread.Sleep(5000);

            searchField.SendKeys(Keys.Return);

            var searchResults = driver.FindElements(countElement);

            Assert.IsTrue(searchResults[0].Text.Contains(searchText, StringComparison.OrdinalIgnoreCase));

            Assert.IsTrue(searchResults[5].Displayed);

            Assert.AreEqual(10, searchResults.Count);

            /*var extractedText = searchResults[0].Text;
            var formatedText = extractedText.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

            Assert.IsTrue(pos != -1);*/


        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}