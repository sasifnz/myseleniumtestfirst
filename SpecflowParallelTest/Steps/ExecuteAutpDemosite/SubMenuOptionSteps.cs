using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]

    public class SubMenuOptionSteps
    {
        private IWebDriver _driver;
        public SubMenuOptionSteps (IWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"click on Automation Tools and display sub menu option")]
        public void ThenClickOnAutomationToolsAndDisplaySubMenuOption()
        {
            var element = _driver.FindElement(By.Id("cssmenu"));
            var elementli = element.FindElements(By.TagName("li"));
            var AutomationToolElement = elementli[1];
            AutomationToolElement.Click();
            Thread.Sleep(1000);
        }
        [Then(@"check the dropdown contains Selenium and BDD")]
        public void ThenCheckTheDropdownContainsSeleniumAndBDD()
        {
            

            //1.find css menu
            var element = _driver.FindElement(By.Id("cssmenu"));
            var elementli = element.FindElements(By.TagName("li"));

            //2.Find Automation menu element

            var Automation = elementli[1];
            var AutomationliElements = Automation.FindElements(By.TagName("li"));

            //3. Find Selenium insise step 2
            var MySeleinumlielement = AutomationliElements[0];
            Console.WriteLine("printing actual text " + MySeleinumlielement.Text);

            Assert.AreEqual("Selenium", MySeleinumlielement.Text);
            MySeleinumlielement.Click();
            Thread.Sleep(500);


            //4. Find Selenium BDD inside step 2
            var MyBDDelement = AutomationliElements[4];
            Assert.AreEqual("BDD", MyBDDelement.Text);

            //5. Find Selenium WebDriver
            var SeleniumWebDriver = _driver.FindElement(By.Id("Selenium WebDriver"));
            Assert.AreEqual("Selenium WebDriver", SeleniumWebDriver.Text);

            //6. Expand BDD 
            MyBDDelement.Click();
            Thread.Sleep(500);

            var specflowelement = AutomationliElements[6 - 1];
            Assert.AreEqual("Specflow", specflowelement.Text);

            //7. Find Cucumber

            var cucumberelement = AutomationliElements[7 - 1];
            Assert.AreEqual("Cucumber", cucumberelement.Text);
        }

    }
}
