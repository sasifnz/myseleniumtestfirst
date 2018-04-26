using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class TravelflightSearchSteps
    {
        private IWebDriver _driver;
     //   private object element;

        public TravelflightSearchSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I connect to SA SoundsAir website")]
        public void GivenIConnectToSASoundsAirWebsite()
        {
            _driver.Navigate().GoToUrl("https://apps8.tflite.com/Public/SA/Booking/Search");
        }
        
        [Given(@"Select radio button for Round trip")]
        public void GivenSelectRadioButtonForRoundTrip()
        {
            Thread.Sleep(1000);
           // var selectRoundtrip = _driver.FindElement(By.CssSelector(".control.control--radio"));
            //var selectRoundtrip = _driver.FindElement(By.CssSelector("label["));
            //selectRoundtrip.Click();
        }
        
        [Given(@"choose from City")]
        public void GivenChooseFromCity()
        {
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

        [Given(@"Choose travelling city")]
        public void GivenChooseTravellingCity()
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

        [Given(@"choose travelling date")]
        public void GivenChooseTravellingDate()
        {
            Thread.Sleep(1000);
            /*passing the constant value for date
            var departdate = _driver.FindElement(By.Id("depart_date"));
            //actions.MoveToElement(departdate).Click().Perform();
            departdate.Click();
            Thread.Sleep(1000);
            
            var departday = _driver.FindElement(By.CssSelector(".day[data-day='04/30/2018']")); 
            departday.Click(); */

            //Depart Date Picking -  System date
            var selectdepartdate = (_driver.FindElement(By.Id("depart_date")));
            selectdepartdate.Click();
            Thread.Sleep(1000);
            var DepartCalender = (_driver.FindElement(By.ClassName("bootstrap-datetimepicker-widget")));

            var SysdateDepart = (DateTime.Now.AddDays(10)); //Selecting System date + 10days

            var DateTimeString = string.Format("{0:MM/dd/yyyy}", SysdateDepart);

            var MyCssSelector = string.Format("td[data-day='{0}']", DateTimeString);

            var TDDepartElement = (DepartCalender.FindElement(By.CssSelector(string.Format("td[data-day='{0}']", DateTimeString))));
            TDDepartElement.Click();
            Thread.Sleep(100);

        }

        [Given(@"choose returning date")]
        public void GivenChooseReturningDate()
        {
            Thread.Sleep(000);
            /* Return date - passed as system date
            var returnday = _driver.FindElement(By.Id("return_date"));
            returnday.Click();
            Thread.Sleep(2000);

            var departday = _driver.FindElement(By.CssSelector(".day[data-day='05/05/2018']"));
            departday.Click();  */

            //Return Date Picking 
            var selectreturndate = (_driver.FindElement(By.Id("return_date")));
            selectreturndate.Click();
            Thread.Sleep(100);
            var ReturnCalender = (_driver.FindElement(By.ClassName("bootstrap-datetimepicker-widget")));

            var SysdateReturn = (DateTime.Now.AddDays(14)); //Selecting System date + 10days

            var DateTimeStringReturn = string.Format("{0:MM/dd/yyyy}", SysdateReturn);

            var MyCssSelectorReturn = string.Format("td[data-day='{0}']", DateTimeStringReturn);

            var TDReturnElement = (ReturnCalender.FindElement(By.CssSelector(string.Format("td[data-day='{0}']", DateTimeStringReturn))));

            TDReturnElement.Click();
            Thread.Sleep(100);
        }
        
        [Given(@"number of Adults travelling")]
        public void GivenEnterNumberOfAdultsTravelling()
        {
            var Adult = _driver.FindElement(By.CssSelector("button[data-field=adults][data-type=plus]"));
            Adult.Click();
            var value = _driver.FindElement(By.CssSelector("input[name=adults].form-control"));
            //var Actualvalue = SeleniumGetMethods.GetText(_driver, "input[name=Adults].form-control", "cssselector");
            Assert.AreEqual("2", value.GetAttribute("value"));
            Thread.Sleep(1000);
        }
        
        [Given(@"number of childrens travelling")]
        public void GivenEnterNumberOfChildrensTravelling()
        {

            var children = _driver.FindElement(By.CssSelector("button[data-field=children][data-type=plus]"));
            children.Click();
            var value = _driver.FindElement(By.CssSelector("input[name=children].form-control"));
            Assert.AreEqual("1", value.GetAttribute("value"));
            Thread.Sleep(1000);
            Console.WriteLine(value.Text);
        }
        
        [Given(@"number of Infants travelling")]
        public void GivenEnterNumberOfInfantsTravelling()
        {
          var infant = _driver.FindElement(By.CssSelector("button[data-field=infants][data-type=plus]"));
            infant.Click();
            Thread.Sleep(1000);
        }
        
        [Given(@"select search to find flights")]
        public void GivenSelectSearchToFindFlights()
        {
            var search = _driver.FindElement(By.CssSelector(".form-control.btn-secondary"));
            search.Submit();
            Thread.Sleep(2000);
        }
    }
}
