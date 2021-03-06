﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowParallelTest.Steps
{
    [Binding]
    public class LoginSteps
    {

        private IWebDriver _driver;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
        }


        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            _driver.FindElement(By.Name("UserName")).SendKeys((String)data.UserName);
            _driver.FindElement(By.Name("Password")).SendKeys((String)data.Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            Thread.Sleep(1000);
            _driver.FindElement(By.Name("Login")).Submit();
            Thread.Sleep(2000);
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            var element = _driver.FindElement(By.XPath("//h1[contains(text(),'Execute Automation Selenium')]"));

            //An way to assert multiple properties of single test
            Assert.Multiple(() =>
            {
                //Assert.That(element.Text, Is.Null, "Header text not found !!!");
                Assert.That(element.Text, Is.Not.Null, "Header text not found !!!");
            });
        }

    
        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            _driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Given(@"I enter username")]
        public void GivenIEnterUsername()
        {
            var element = _driver.FindElement(By.Name("UserName"));
            element.SendKeys("admin");
        }

        [Then(@"I enter password")]
        public void ThenIEnterPassword()
        {
            var element = _driver.FindElement(By.Name("Password"));
            element.SendKeys("admin");
        }

        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            var element = _driver.FindElement(By.Name("Login"));
            element.Submit();
            //Thread.Sleep(5000);
     
        }


    }
}
