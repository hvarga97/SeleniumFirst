using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        //Getting value from textbox
        //public static string GetText(string element, ProperyType elementtype)
        //{
        //    if (elementtype == ProperyType.Id)
        //        return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
        //    if (elementtype == ProperyType.Name)
        //        return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
        //    else return String.Empty;
        //}

    //part 10
        
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        //Getting value from Drop Down List
        //public static string GetTextFromDDL(string element, ProperyType elementtype)
        //{
        //    if (elementtype == ProperyType.Id)
        //        return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
        //    if (elementtype == ProperyType.Name)
        //        return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
        //    else return String.Empty;
        //}

    //part 10
        public static string GetTextFromDDL(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
