using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;



namespace GoogleSearchResultsTests
{
    public class GoogleSearchResults : BaseTest
    {
        private const string searchText = "Who the fuck is Alice";


        [Test]
        public void SearchResultInspection()
        {
            new SearchPage(driver)
                .Search(searchText)
                .CheckResultContains10Results();

            // Page Objects


            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(inputSearchField)); // old way

            //wait.Until(drv => SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(inputSearchField)); // new way



            //Assert.IsTrue(searchResults[0].Text.Contains(searchText, StringComparison.OrdinalIgnoreCase));

            //Assert.IsTrue(searchResults[5].Displayed);



            //searchResults[0].Text.ShouldBeSameAs(searchText);

            /*var extractedText = searchResults[0].Text;
            var formatedText = extractedText.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

            Assert.IsTrue(pos != -1);*/
        }

    }
}