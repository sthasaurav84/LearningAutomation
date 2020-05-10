using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleApp2
{
    [TestClass]
    [TestCategory("SearchingFeature"), TestCategory("SampleApp2")]
    public class SearchFunctionality : BaseTest
    {
        public new IWebDriver Driver { get; private set; }
        [TestMethod]
        [Description("Checks to make sure that if we search for browser, that browser comes back.")]
        [TestProperty("Author", "Saurav Shrestha")]

        public void TCID1()  
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            SearchPage searchPage = homePage.Search("blouse");
            Assert.IsTrue(searchPage.Contains(Item.Blouse));
        }

        [TestInitialize]
        public void SetupFoEverySingleTestMethod()
        {
            Driver = GetChromeDriver();
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }      

        [TestCleanup]
        public void CleanUpAfterEveryTestMethod()
        {
            Driver.Close();
            Driver.Quit();
        }


    }
}
