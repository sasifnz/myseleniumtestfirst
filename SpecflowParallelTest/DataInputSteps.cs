using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest
{
    [Binding]
    public class DataInputSteps
    {
        private IWebDriver _driver;
        private object data;

        public  DataInputSteps(IWebDriver driver)
        {
            _driver = driver;
        }
        [Then(@"select title")]
        public void ThenSelectTitle()
        {
            Thread.Sleep(1000);

            //var selectElement = _driver.FindElement(By.("TitleId"));
            SeleniumSetMethods.SelectDropDown(_driver, "TitleId","Mr.","Id");
            //selectElement.Click();
        }
        
        [Then(@"enter Initial")]
        public void ThenEnterInitial()
        {
            _driver.FindElement(By.Id("Initial")).SendKeys("SA");
        }
        
        [Then(@"enter First Name")]
        public void ThenEnterFirstName()
        {
            _driver.FindElement(By.Id("FirstName")).SendKeys("Asif");
        }
              
        [Then(@"enter Middle Name")]
        public void ThenEnterMiddleName()
        {
            _driver.FindElement(By.Id("MiddleName")).SendKeys("SD");
        }
        
        [Then(@"select Gender")]
        public void ThenSelectGender()
        {
            var selectElement = _driver.FindElement(By.Name("Male"));
            selectElement.Click();
        }
        
        [Then(@"select Language")]
        public void ThenSelectLanguage()
        {
            var selectElement = _driver.FindElement(By.Name("Hindi"));
            selectElement.Click();
        }
        
        [Then(@"click Save button")]
        public void ThenClickSaveButton()
        {
            var selectElement = _driver.FindElement(By.Name("Save"));
            selectElement.Click();
        }
    }
}
