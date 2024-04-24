using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoForAutomatedTest
{
    [TestFixture]
    public class GoogleSearchTests
    {

        [Test]
        public void Google_Search_GettingStartedWithAutomatedTesting()
        {
            IWebDriver driver = new ChromeDriver();
            // Navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com");

            // Find the search input field
            IWebElement searchInput = driver.FindElement(By.Name("q"));

            // Enter the search query
            searchInput.SendKeys("Getting started with automated testing");

            // Submit the search query
            searchInput.SendKeys(Keys.Return);

            // Wait for search results page to load
            driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(20);

            // Find and assert search results
            Assert.IsTrue(driver.PageSource.Contains("Getting started with automated testing"));
            driver.Close();
            driver.Quit();
        }

    }
}
