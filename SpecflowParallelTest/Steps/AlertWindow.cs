using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class AlertWindowSteps
    {
        private IWebDriver _driver;
        public AlertWindowSteps(IWebDriver driver)
        {
            _driver = driver;
        }
        [Given(@"I click Generate button")]
        public void GivenIClickGenerateButton()
        {
            var alertwindow = _driver.FindElement(By.Name("generate"));
            alertwindow.Click();
        }
        
        [Then(@"open the alert window")]
        public void ThenOpenTheAlertWindow()
        {
            var alertwindow = _driver.SwitchTo().Alert();
            Assert.IsNotNull(alertwindow);
           
        }
        [Then(@"Dismiss the alert window")]
        public void ThenDismissTheAlertWindow()
        {
            var alertwindow = _driver.SwitchTo().Alert();
            Console.WriteLine(alertwindow.Text);
            alertwindow.Accept();
            Thread.Sleep(1000);
            alertwindow = _driver.SwitchTo().Alert();
            Console.WriteLine(alertwindow.Text);
            alertwindow.Accept();

          }

    }
}
