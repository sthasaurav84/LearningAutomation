using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleApp2
{
    [TestClass]
    [TestCategory("Contact Us Page")]

    public class ContactUsFeature : BaseTest
    {
        public new IWebDriver Driver { get; private set; }

        [TestMethod]
        [TestProperty("Author", "SthaSaurav")]
        [Description("Validate that the contact us page is loaded with a form.")]

        public void TCID2()
        {
            ContactUsPage contactUsPage = new ContactUsPage(Driver);
            contactUsPage.GoTo();
            Assert.IsTrue(contactUsPage.IsLoaded,
                "The contact us page did not open successfully.");
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
        [TestInitialize]
        public void SetupFoEverySingleTestMethod()
        {
            Driver = GetChromeDriver();
        }

        [TestCleanup]
        public void CleanUpAfterEveryTestMethod()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
