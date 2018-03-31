using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class Changelabel
    { 
        private IWebDriver _driver;
        public Changelabel(IWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"check the label Title is displayed")]
        public void ThenCheckTheLabelTitleIsDisplayed()
        {

            var tableElement = _driver.FindElement(By.TagName("table"));
            var tdElements = tableElement.FindElements(By.TagName("td"));

            foreach (var tdElement in tdElements)
            {
                Console.WriteLine(tdElement.Text);
   
            }
            
            //string text = _driver.FindElement(By.Xpath("Title")).Text;

        }
    }
}
