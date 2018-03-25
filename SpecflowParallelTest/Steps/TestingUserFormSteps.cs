using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class TestingUserFormSteps
    {
        private IWebDriver _driver;
        public TestingUserFormSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"I should see menu option '(.*)'")]
        public void ThenIShouldSeeMenuOption(string expected)
        {
           
            var element = _driver.FindElement(By.Id("cssmenu"));
            var elementli = element.FindElements(By.TagName("li"));

            if (expected == "LOGOUT")
            {
                var Actualelement = elementli[0].Text;
                Assert.AreEqual(expected, Actualelement);

            }
            else if (expected == "AUTOMATION TOOLS")
            {
                var Actualelement = elementli[1].Text;
                Assert.AreEqual(expected, Actualelement);

            }
            else if (expected == "USER FORM")
            {

                var Actualelement = element.Text;
                var isContains = Actualelement.Contains(expected);
                Assert.IsTrue(isContains);
            }
            else

            {
                //drag and Drop
                var Actualelement = element.Text;
                var isContains = Actualelement.Contains(expected);
                Assert.IsTrue(isContains);
            }

            
   
            Thread.Sleep(1000);

        }

        [Then(@"I should see the text '(.*)'")]
        public void ThenIShouldSeeTheText(string p0)
        {
            var Element1 = _driver.FindElement(By.TagName("h1"));
            Assert.AreEqual(p0, Element1.Text);
        }

        [Then(@"I should see the text header '(.*)'")]
        public void ThenIShouldSeeTheTextHeader(string p0)
        {
            var Element1 = _driver.FindElement(By.CssSelector("#cssmenu~p"));
            Assert.AreEqual(p0, Element1.Text);
        }


    }
}
