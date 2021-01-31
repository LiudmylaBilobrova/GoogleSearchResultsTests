using NUnit.Framework;
using OpenQA.Selenium;

namespace GoogleSearchResultsTests
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By inputSearchField = By.XPath("//input[@class='gLFyf gsfi']");
        private const string searchText = "Who the fuck is Alice";
        private readonly By googleSearchButton = By.XPath("//input[@name='btnK']");


        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            var searchField = driver.FindElement(inputSearchField);
            searchField.SendKeys(searchText);

            var googleSearch = driver.FindElement(googleSearchButton);
            googleSearch.Click();
        }

        [TearDown]
        public void TearDown()
        {
        
        }
    }
}