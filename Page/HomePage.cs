using System;
using OpenQA.Selenium;

namespace SampleApp2
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void GoTo()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com");
        }

        internal SearchPage Search(string itemToSearchFor)
        {
            driver.FindElement(By.Id("search_query_top")).SendKeys(itemToSearchFor);
            driver.FindElement(By.Name("submit_search")).Click();
            return new SearchPage(driver);
        }
    }
}