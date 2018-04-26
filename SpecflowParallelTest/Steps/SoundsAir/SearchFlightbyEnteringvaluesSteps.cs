using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class SearchFlightbyEnteringvaluesSteps
    {
        private IWebDriver _driver;
        //private object data;

        public SearchFlightbyEnteringvaluesSteps(IWebDriver driver)
        {
            _driver = driver;

         }
        [Then(@"Enter number of Adult")]
        public void ThenEnterNumberOfAdult()
        {
            var Adults = _driver.FindElement(By.Name("Adults"));
            Adults.Click();
            Adults.SendKeys(Keys.Control+"A");
            Adults.SendKeys("2");
            Adults.SendKeys(Keys.Control + Keys.Tab);

            //_driver.FindElement(By.Name("Adults")).SendKeys("2");

        }
        
        [Then(@"Enter number of child and number of Infants")]
        public void ThenEnterNumberOfChildAndNumberOfInfants()
        {
            var children = _driver.FindElement(By.Name("Children"));
                children.Click();
                children.SendKeys(Keys.Control + "A");
                children.SendKeys("1");
                children.SendKeys(Keys.Control + Keys.Tab);

            //_driver.FindElement(By.Name("Children")).SendKeys("1");
            
            var Infants = _driver.FindElement(By.Name("Infants"));
            Infants.Click();
            Infants.SendKeys(Keys.Control + "A");
            Infants.SendKeys("1");
            Thread.Sleep(1000);
            Console.WriteLine("Infants");
        }
    }
}
