using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowParallelTest
{
   public static class SeleniumSetMethods
    {
        //EnterText
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        internal static void SelectTitle(IWebDriver driver, string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        //Click into a button, Checkbox, option etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementtype == "Class")
                new SelectElement(driver.FindElement(By.ClassName(element))).SelectByText(value);
            if (elementtype == "CssSelector")
                new SelectElement(driver.FindElement(By.CssSelector(element))).SelectByText(value);
        }

    }
}
