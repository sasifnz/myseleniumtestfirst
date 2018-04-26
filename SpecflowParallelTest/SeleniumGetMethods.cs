using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowParallelTest
{
    public static class SeleniumGetMethods
    {
        public static string GetText(IWebDriver driver, string element, string findBy)
        {
            if (findBy == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (findBy == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            if (findBy == "cssselector")
                return driver.FindElement(By.CssSelector(element)).GetAttribute("value");
            else return String.Empty;
        }

        

        public static string GetTextFromDDL(IWebDriver driver, string element, string findBy)
        {
            if (findBy == "Id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (findBy == "Name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
