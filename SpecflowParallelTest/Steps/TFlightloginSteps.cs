using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowParallelTest.Steps
{
    [Binding]

    
    public class TFlightloginSteps
    {
        private IWebDriver _driver;
        private string newTabHandle;
        private object data;

        public TFlightloginSteps(IWebDriver driver)
        {
            _driver = driver;
        }
        [Given(@"I connect to Sounds air website")]
        public void GivenIConnectToSoundsAirWebsite()
        {
            _driver.Navigate().GoToUrl("https://www.soundsair.com");
        }
        
        [Then(@"click login button")]
        public void ThenClickLoginButton()
        {
            var element = _driver.FindElement(By.CssSelector(".navbar-right .navbar-nav"));
            var elementli = element.FindElements(By.TagName("li"));
            var AutomationToolElement = elementli[0];
            AutomationToolElement.Click();
            Thread.Sleep(1000);
        }
        
        [Then(@"click Sign Up Here")]
        public void ThenClickSignUpHere()
        {
            string newtabhandle = _driver.WindowHandles.Last();
            var newtab = _driver.SwitchTo().Window(newtabhandle);

            //var expectedNewTitle = "https://soundsair.tflite.com/Public/sa/Account/Login?_ga=2.263944388.935728109.1523697175-57294844.1523697175";
            var SignInelement = newtab.FindElement(By.ClassName("panel-title"));
            Assert.AreEqual("Sign In", SignInelement.Text);
            Thread.Sleep(1000);

            var Signuphere = _driver.FindElement(By.CssSelector("a[href='./SignUp']"));
            Signuphere.Click();
            Thread.Sleep(1000);

        }
        
        [Then(@"navigate the user to singup window")]
        public void ThenNavigateTheUserToSingupWindow()
        {
            string newtabhandle = _driver.WindowHandles.Last();
            var Signup = _driver.SwitchTo().Window(newtabhandle);

            var SignUpelement = Signup.FindElement(By.ClassName("panel-title"));
            Assert.AreEqual("Sign up", SignUpelement.Text);
            Thread.Sleep(1000);
        }

        [Then(@"Enter firstname & Enter lastname")]
        public void ThenEnterFirstNameEnterLastName(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            
            _driver.FindElement(By.Id("firstname")).SendKeys((String)data.firstname);
            _driver.FindElement(By.Id("lastname")).SendKeys((String)data.lastname);
            
        }
        [Then(@"Enter Emailaddress & Enter ContactNumber")]
        public void ThenEnterEmailaddressEnterContactNumber(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _driver.FindElement(By.Id("email")).SendKeys((String)data.Emailaddress);
            // converting Int to string -- concept in c# is called as boxing & un-boxing
            _driver.FindElement(By.Id("phone")).SendKeys(Convert.ToString(data.ContactNumber));
            // for passing integer as constant value
            //_driver.FindElement(By.Id("phone")).SendKeys(("0123456789"));
            Thread.Sleep(2000);
        }

        [Then(@"Enter UserName")]
        public void ThenEnterUserName(Table table)
        {
            _driver.FindElement(By.Id("username")).SendKeys("SD");
          
        }

        [Then(@"Enter Password & ConfirmPassword")]
        public void ThenEnterPasswordConfirmPassword(Table table)
        {
            //dynamic data = table.CreateDynamicInstance();
            //_driver.FindElement(By.Id("password")).SendKeys((String)data.Password);
            //_driver.FindElement(By.Id("password_confirm")).SendKeys((String)data.ConfirmPassword);
            _driver.FindElement(By.Id("password")).SendKeys("!@#$%1q");
            _driver.FindElement(By.Id("password_confirm")).SendKeys("!@#$%1q");
        }

        [Then(@"Click Signup")]
        public void ThenClickSignUp()
        {
            //var signup = _driver.FindElement(By.CssSelector(".form-group .form-control"));
            var signup = _driver.FindElement(By.CssSelector(".form-group button"));

            //"form-control.btn-secondary.btn-labeled.btn-block.btn.labled-lg"));
            //WebElement click = _driver.FindElement(By.XPath("//button[contains(text(),'signup')]"));
            //click.click();
            //var signup = _driver.FindElement(By.ClassName
            //("btn - label"));

            signup.Submit();
            Thread.Sleep(2000);
        }

    }
}
