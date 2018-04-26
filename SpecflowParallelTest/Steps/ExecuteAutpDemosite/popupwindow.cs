using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class Popupwindow
    {
        private IWebDriver _driver;
              
        public Popupwindow (IWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"User clicks on the link")]
        public void ThenUserClicksOnTheLink()
        {
            var popupElement = _driver.FindElement(By.CssSelector(".detail_box p a"));
            popupElement.Click();

        }


         [Then(@"Pop-up window displayed")]
        public void ThenPop_UpWindowDisplayed()
        {
            var windowcount= _driver.WindowHandles.Count;
            Assert.AreEqual(2, windowcount);
            Thread.Sleep(1000);
           

        }
    }
}
