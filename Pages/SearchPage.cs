﻿using System;
using OpenQA.Selenium;

namespace SampleApp2
{
    internal class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal bool Contains(Item itemToCheckFor)
        {
            switch (itemToCheckFor)
            {
                case Item.Blouse:
                    return driver.FindElement(By.XPath("//*[@title='Blouse']")).Displayed;                   
                default:
                    throw new ArgumentOutOfRangeException("No such item exists in this collection");
                    break;
            }

                
        }
    }
}