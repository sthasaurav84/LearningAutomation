using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleApp2
{
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }
    }
}