using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowParallelTest.Steps.SoundsAir
{
    [Binding]
    public class BookingflightSteps
    {
        
        private IWebDriver _driver;
        public object WindowHandles { get; private set; }
        public BookingflightSteps(IWebDriver driver)
        {
            _driver = driver;
        }
        
        [Given(@"Select date")]
        public void GivenSelectDate()
        {
            Thread.Sleep(15000);
            var dayselected = _driver.FindElement(By.ClassName("owl-stage-outer"));
            var SysdateDepart = (DateTime.Now.AddDays(10)); //Selecting System date + 10days

            var DateTimeString = string.Format("{0:yyyy-MM-dd}", SysdateDepart);

            var MyCssSelector = string.Format("td[data-day='{0}']", DateTimeString);

            var TDDepartElement = (dayselected.FindElement(By.CssSelector(string.Format("li[data-date='{0}']", DateTimeString))));
            Thread.Sleep(1000);
            TDDepartElement.Click();
            Thread.Sleep(100);
        }
        
        [Given(@"Select departure flight")]
        public void GivenSelectFlight()
        {
            Thread.Sleep(10000);
            var selectoutgoingprice = _driver.FindElements(By.ClassName("booking-class-item-wrap"));
            var selectoutgoingarrayelement = (selectoutgoingprice[0]);
            var selectoutgoingfarearray = _driver.FindElements(By.ClassName("booking-item-container"));
            
            var arraylabel = selectoutgoingfarearray[2].FindElement(By.ClassName("fc_radio"));
            
            arraylabel.Click();
            Thread.Sleep(1000);

        }
        [Given(@"Select Return flight")]
        public void GivenSelectReturnFlight()
        {
            Thread.Sleep(10000);

            var daySelected = _driver.FindElement(By.CssSelector(".return-container + .results-data"));
            
            var selectreturningprice = daySelected.FindElements(By.ClassName("booking-class-item-wrap"));
            var selectreturnflightarrayelement = (selectreturningprice[0]);
            var selectReturnFareArray = selectreturnflightarrayelement.FindElements(By.ClassName("booking-item-container"));
            var bestFare = selectReturnFareArray[2];

            var arraylabel = bestFare.FindElement(By.ClassName("fc_radio"));
            arraylabel.Click();
            Thread.Sleep(1000);
        }
        [Given(@"selectproceedbutton")]
        public void GivenSelectproceedbutton()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
            var selectProceed = _driver.FindElement(By.CssSelector(".btn-group .btn-success"));
            selectProceed.Click();
            Thread.Sleep(1000);
        }

        [Given(@"Adult1 details")]
        public void GivenAdultsDetails()
        {
            var liarrayelement = _driver.FindElements(By.CssSelector("li.underline"));
            Thread.Sleep(5000);
            var Adult1 = liarrayelement[0];
            SelectElement ss = new SelectElement(Adult1.FindElement(By.CssSelector("select")));
            Thread.Sleep(3000);
                Console.WriteLine(ss.Options);
                foreach (IWebElement dropdownopt in ss.Options)
                {
                    if (dropdownopt.Text == "Hon")
                    {
                        
                        dropdownopt.Click();
                    }


                }
                // Passing Name for Adult 1
            var AdultName1 = _driver.FindElements(By.CssSelector(".form-control.passenger-first-name"));
            var firstName = AdultName1[0];
            firstName.Click();
            firstName.SendKeys("Asif");

            var Adultmiddlename = _driver.FindElements(By.CssSelector(".form-control.passenger-middle-name"));
            var middleName = Adultmiddlename[0];
            middleName.Click();
            middleName.SendKeys("Ullah");

            var Adultlastname = _driver.FindElements(By.CssSelector(".date-pick-years.form-control.passenger-last-name"));
            var lastName = Adultlastname[0];
            lastName.Click();
            lastName.SendKeys("Syed");
        }

        [Given(@"Enter Adult(.*) detaiils")]
        public void GivenEnterAdultDetaiils(int p0)
        {
            // Titel for 2nd Adult

            var liarrayelement = _driver.FindElements(By.CssSelector("li.underline"));
            Thread.Sleep(5000);
            var Adult1 = liarrayelement[1];
            SelectElement ss = new SelectElement(Adult1.FindElement(By.CssSelector("select")));
            Thread.Sleep(3000);
            Console.WriteLine(ss.Options);
            foreach (IWebElement dropdownopt in ss.Options)
            {
                if (dropdownopt.Text == "Rev")
                {

                    dropdownopt.Click();
                }


            }
            // Passing Name for Adult 2
            var AdultName2 = _driver.FindElements(By.CssSelector(".form-control.passenger-first-name"));
            var Adult2firstName = AdultName2[1];
            Adult2firstName.Click();
            Adult2firstName.SendKeys("Test99");

            var Adult2middlename = _driver.FindElements(By.CssSelector(".form-control.passenger-middle-name"));
            var Adult2middleName = Adult2middlename[1];
            Adult2middleName.Click();
            Adult2middleName.SendKeys("SD");

            var Adult2lastname = _driver.FindElements(By.CssSelector(".date-pick-years.form-control.passenger-last-name"));
            var Adult2lastName = Adult2lastname[1];
            Adult2lastName.Click();
            Adult2lastName.SendKeys("Syed2");
        }

        [Given(@"Childrens details")]
        public void GivenChildrensDetails()
        {
            // Titel for Children

            var liarrayelement = _driver.FindElements(By.CssSelector("li.underline"));
           // Thread.Sleep(5000);
            var Child = liarrayelement[2];
            SelectElement ss = new SelectElement(Child.FindElement(By.CssSelector("select")));
            //Thread.Sleep(3000);
            Console.WriteLine(ss.Options);
            foreach (IWebElement dropdownopt in ss.Options)
            {
                if (dropdownopt.Text == "Miss")
                {

                    dropdownopt.Click();
                }


            }
            // Passing Name for Child
            var ChildName = _driver.FindElements(By.CssSelector(".form-control.passenger-first-name"));
            var ChildfirstName = ChildName[2];
            ChildfirstName.Click();
            ChildfirstName.SendKeys("Arisha");

            var Childmiddlename = _driver.FindElements(By.CssSelector(".form-control.passenger-middle-name"));
            var ChildmiddleName = Childmiddlename[2];
            ChildmiddleName.Click();
            ChildmiddleName.SendKeys("Samrish");

            var Childlastname = _driver.FindElements(By.CssSelector(".date-pick-years.form-control.passenger-last-name"));
            var ChildlastName = Childlastname[2];
            ChildlastName.Click();
            ChildlastName.SendKeys("Syed");

            //Child Age
            //var ChildAge = _driver.FindElements(By.CssSelector(".form-control.passenger-age.parsley-error"));
            //SelectElement ss = new SelectElement(_driver.FindElement(By.CssSelector(".form-control.passenger-age")));
            var childcollection = _driver.FindElements(By.CssSelector(".list-unstyled.booking-item-passengers.card.panel-account"));
            var childfield = childcollection[1];
            var childdata = childfield.FindElement(By.ClassName("underline"));
            //var childage = childdata.FindElement(By.ClassName("passenger-age"));
           // childage.Click();
        
            SeleniumSetMethods.SelectDropDown(_driver, ".form-control.passenger-age", "3", "CssSelector");
            Thread.Sleep(5000);
           

        }

        [Given(@"Infants details")]
        public void GivenInfantsDetails()
        {
            // Passing Name for Child
            var Infant1Name = _driver.FindElements(By.CssSelector(".form-control.passenger-first-name"));
            var InfantfirstName = Infant1Name[3];
            InfantfirstName.Click();
            InfantfirstName.SendKeys("Arsh");

            var Infant1middlename = _driver.FindElements(By.CssSelector(".form-control.passenger-middle-name"));
            var InfantmiddleName = Infant1middlename[3];
            InfantmiddleName.Click();
            InfantmiddleName.SendKeys("SD");

            var Infantlastname = _driver.FindElements(By.CssSelector(".date-pick-years.form-control.passenger-last-name"));
            var InfantkidlastName = Infantlastname[3];
            InfantkidlastName.Click();
            InfantkidlastName.SendKeys("Syed");

        }

        [Given(@"Enter Customer Details")]
        public void GivenEnterCustomerDetails()
        {
            
            _driver.FindElement(By.Name("email")).SendKeys("temp12345@gmail.com");
            _driver.FindElement(By.Name("phone")).SendKeys("640000000");
            _driver.FindElement(By.Name("mobile")).SendKeys("0220000000");

            //save customer details
            var Savedetails = _driver.FindElement(By.Id("customer_save_details"));
            Savedetails.Click();
            Thread.Sleep(1000);
         }

        [Given(@"Select Continue")]
        public void GivenSelectContinue()
        {
            var Continue = _driver.FindElement(By.CssSelector("button.btn.btn-success"));
            Continue.Submit();
            Thread.Sleep(1000);
        }

        [Given(@"Confrim and navigate to Payment page")]
        public void GivenConfrimAndNavigateToPaymentPage()
        {
            Thread.Sleep(7000);
            var Acceptterms = _driver.FindElement(By.Id("check1"));
            Acceptterms.Click();
            Thread.Sleep(5000);

            var Continue = _driver.FindElement(By.CssSelector(".btn-labeled.labled-lg"));
            Continue.Submit();
            Thread.Sleep(10000);
        }


    }
}
