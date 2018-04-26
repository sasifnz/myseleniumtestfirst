using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class OnewayflightSteps
    {
        private IWebDriver _driver;
        public OnewayflightSteps(IWebDriver driver)
        {
            _driver = driver;
        }
        [Given(@"Select radiobutton oneway")]
        public void GivenSelectRadiobuttonOneway()
        {
            Thread.Sleep(1000);
            var oneway = _driver.FindElement(By.CssSelector("#filter li:last-child label"));
            Thread.Sleep(1000);
            oneway.Click();
            
        }
    }
}
