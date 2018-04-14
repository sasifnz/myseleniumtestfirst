using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class DataInputforPopupSteps
    {
        private IWebDriver _driver;
        private object driver;

        public object WindowHandles { get; private set; }

        public DataInputforPopupSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Select Title")]
        public void ThenSelectTitle()
        {
           
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
            var selectTitle = _driver.FindElement(By.Id("TitleId"));

            SeleniumSetMethods.SelectDropDown(_driver, "TitleId", "Mr.", "Id");
            Thread.Sleep(1000);
            //_driver.Close();
            //_driver.SwitchTo().Window(parentwindow);

        }

        [Then(@"Enter Initial")]
        public void ThenEnterInitial()
        {
            _driver.FindElement(By.Id("Initial")).SendKeys("AS");
            //Assert.AreEqual("AS", )
        }
        
        [Then(@"enter MiddleName")]
        public void ThenEnterMiddleName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Enter Last Name")]
        public void ThenEnterLastName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Select Country")]
        public void ThenSelectCountry()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"close the popupwindow")]
        public void ThenCloseThePopupwindow()
        {
            var parentwindow = _driver.WindowHandles.First();
            _driver.Close();
            _driver.SwitchTo().Window(parentwindow);
        }
    }
}
