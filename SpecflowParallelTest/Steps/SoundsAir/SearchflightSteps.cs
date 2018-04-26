using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class SearchflightSteps
    {
        private IWebDriver _driver;
        private object value;

        public SearchflightSteps(IWebDriver driver)
        {
            _driver = driver;
        }


        [Given(@"I connect to Sounds Air website")]
        public void GivenIConnectToSoundsAirWebsite()
        {
            _driver.Navigate().GoToUrl("https://www.soundsair.com");
        }
        
        [Then(@"Search Flights for Round trip")]
        public void ThenSearchFlightsForRoundTrip()
        {
            var selectRoundtrip = _driver.FindElement(By.CssSelector(".control-group .control"));
                selectRoundtrip.Click();
        }
        
        [Then(@"select Departing location")]
        public void ThenSelectDepartingLocation()
        {
            //var DepartingCity = SeleniumGetMethods.GetTextFromDDL(_driver, "from", "Id");
            // Console.WriteLine(titleValue);
           SelectElement ss = new SelectElement(_driver.FindElement(By.Id("from")));

            Console.WriteLine(ss.Options);
            foreach (IWebElement element in ss.Options)
            {
                if (element.Text == "Wellington")
                {
                    element.Click();
                }
                
            }
            
            
        }
        
        [Then(@"select Travelling to city")]
        public void ThenSelectTravellingToCity()
        {
            SelectElement ss = new SelectElement(_driver.FindElement(By.Id("to")));

            Console.WriteLine(ss.Options);
            foreach (IWebElement element in ss.Options)
            {
                if (element.Text == "Nelson")
                {
                    element.Click();
                }
            }
            }

        [Then(@"Select Departing date")]
        public void ThenSelectDepartingDate()
        {
            var departdate = _driver.FindElement(By.Id("depart_date"));
            departdate.Click();

            var departday = _driver.FindElement(By.CssSelector(".day[data-day='04/26/2018']"));
            departday.Click();
        }

        [Then(@"In Return date the previous days from departing days should be disabled")]
        public void ThenInReturnDateThePreviousDaysFromDepartingDaysShouldBeDisabled()
        {
            var returnday = _driver.FindElement(By.Id("return_date"));
            returnday.Click();

            var disableday = _driver.FindElement(By.CssSelector(".day[data-day='04/25/2018']"));
            var disableclassval = disableday.GetAttribute("class");
            Assert.AreEqual("day disabled", disableclassval);           
        }

        [Then(@"Select Return date")]
        public void ThenSelectReturnDate()
        {
            Thread.Sleep(000);
            var returnday = _driver.FindElement(By.Id("return_date"));
            returnday.Click();
            Thread.Sleep(2000);

            var departday = _driver.FindElement(By.CssSelector(".day[data-day='04/27/2018']"));
            departday.Click();

        }


        [Then(@"Select number of Adult")]
        public void ThenSelectNumberOfAdult()
        {
            var Adult = _driver.FindElement(By.CssSelector("button[data-field=Adults][data-type=plus]"));
            //var Adult = _driver.FindElement(By.CssSelector(".input-group-btn")); 
            // var Adult = _driver.FindElement(By.CssSelector("span[class='input-group-btn']"));
            Adult.Click();
            var value = _driver.FindElement(By.CssSelector("input[name=Adults].form-control"));
            //var Actualvalue = SeleniumGetMethods.GetText(_driver, "input[name=Adults].form-control", "cssselector");
            Assert.AreEqual("2", value.GetAttribute("value"));
            Thread.Sleep(1000);
        }

        [Then(@"select number of child and number of Infants")]
        public void ThenSelectNumberOfChildAndNumberOfInfants()
        {
            var children = _driver.FindElement(By.CssSelector("button[data-field=Children][data-type=plus]"));
            children.Click();
            var value = _driver.FindElement(By.CssSelector("input[name=Children].form-control"));
            Assert.AreEqual("1", value.GetAttribute("value"));
            Thread.Sleep(1000);
            Console.WriteLine(value.Text);

            var infant = _driver.FindElement(By.CssSelector("button[data-field=Infants][data-type=plus]"));
            infant.Click();
            Thread.Sleep(1000);

            //var value1 = _driver.FindElement(By.CssSelector("input[name=Infants].form-control"));

        }
        [Then(@"click Search for flights")]
        public void ThenClickSearchForFlights()
        {
            var search = _driver.FindElement(By.CssSelector("button.btn.btn-primary-invert"));
            search.Submit();
            Thread.Sleep(1000);
        }
    }
}
