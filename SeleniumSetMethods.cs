using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        //Enter text method
        //public static void EnterText(IWebPropertiesCollection.driver PropertiesCollection.driver, string element, string value, string elementtype) - method without global properties
        //public static void EnterText(string element, string value, ProperyType elementtype)
        //{
        //    if(elementtype == ProperyType.Id)
        //        PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
        //    if (elementtype == ProperyType.Name)
        //        PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        //}

        //Exteded method for entering text in the control

    //part 10
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Click into a button, Checkbox, option etc
        //public static void Click(IWebPropertiesCollection.driver PropertiesCollection.driver, string element, string elementtype) - method without global properties
        //public static void Click(string element, ProperyType elementtype)
        //{
        //    if (elementtype == ProperyType.Id)
        //        PropertiesCollection.driver.FindElement(By.Id(element)).Click();
        //    if (elementtype == ProperyType.Name)
        //        PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        //}

        //Click into a button, Checkbox, option etc
        
    //part 10
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        //Selecting a drop down control
        //public static void SelectDropDown(IWebPropertiesCollection.driver PropertiesCollection.driver, string element, string value, string elementtype) - method without global properties
        //public static void SelectDropDown(string element, string value, ProperyType elementtype)
        //{
        //    if (elementtype == ProperyType.Id)
        //        new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
        //    if (elementtype == ProperyType.Name)
        //        new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        //}

        //Selecting a drop down control

    //part 10
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
