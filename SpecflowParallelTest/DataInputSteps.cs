using NUnit.Framework;
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
        [Then(@"verify the input data")]
        public void ThenVerifyTheInputData()
        {
          //  var InitialElement = _driver.FindElement(By.Id("Initia"));

           var titleValue = SeleniumGetMethods.GetTextFromDDL(_driver, "TitleId", "Id");
           // Console.WriteLine(titleValue);
            Assert.AreEqual("Mr.", titleValue);

            var InitialValue = SeleniumGetMethods.GetText(_driver, "Initial", "Id");
          //  Console.WriteLine(InitialValue);
            Assert.AreEqual("SA", InitialValue);

            var name = SeleniumGetMethods.GetText(_driver, "FirstName", "Id");
           // Console.WriteLine(name);
            Assert.AreEqual("Asif", name);

            var middlename = SeleniumGetMethods.GetText(_driver, "MiddleName", "Id");
           // Console.WriteLine(middlename);
            Assert.AreEqual("SD", middlename);

            var gender = SeleniumGetMethods.GetText(_driver, "Male", "Name");
           // Console.WriteLine(gender);
            Assert.AreEqual("male", gender);

            var language = SeleniumGetMethods.GetText(_driver, "Hindi", "Name");
           // Console.WriteLine(language);
            Assert.AreEqual("hindi", language);
        }

    }
}
