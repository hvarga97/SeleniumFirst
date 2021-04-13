using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFirst_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        //Create the reference for browser
        //IWebPropertiesCollection.driver PropertiesCollection.driver = new ChromePropertiesCollection.driver();     //Global variable - used before calling line 26 (calling PropertiesCollection.driver from PropertiesCollectio)
        
        static void Main(string[] args)
        {
        }

        [SetUp]                                                         //Method that is called immediatelly before test
        public void Initialize()                                        //Initialization part
        {

            PropertiesCollection.driver = new ChromeDriver();

            //Navigate to Google page
            //PropertiesCollection.driver.Navigate().GoToUrl("http://www.google.com");
            //Navigating to demo site
            //PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login"); - site after clicking login button
            PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            Console.WriteLine("Opened URL");                            //Console output text
        }

        [Test]                                                          //Method that is called from NUnit test runner
        public void ExecuteTest()                                       //Execution part 1
        {
            //Find the element
            //IWebElement element = PropertiesCollection.driver.FindElement(By.Name("q"));

            //Perform ops
            //element.SendKeys("executeautomation");

            //Console.WriteLine("Executed Test");

            //DropDown
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", ProperyType.Id);

            //Text
            // SeleniumSetMethods.EnterText("Initial", "executeautomation", ProperyType.Name);

            //Get the value from textbox calling the created method
            //Console.WriteLine("The value from my Title is:" + SeleniumGetMethods.GetText("TitleId", ProperyType.Id));

            //Get the selected value from a drop down list calling created method
            //Console.WriteLine("The value from my Initial is" + SeleniumGetMethods.GetText("Initial", ProperyType.Name));

            //Click
            //SeleniumSetMethods.Click("Save", ProperyType.Name);

         //part 8
            //Initialize the page by calling its reference
            //EAPageObject page = new EAPageObject();

            //pageEA.txtInitial.SendKeys("executeautomation");

            //pageEA.btnSave.Click();

         //part 9
            //Login to Application
            //LoginPageObject pageLogin = new LoginPageObject();
            //EAPageObject pageEA = pageLogin.Login("execute", "automation");

            //pageEA.FillUserForm("KK", "Hrv", "Hrvoje");

         //part 12

            ExcelLib.PopulateInCollection(@"\\Mac\Home\Desktop\Book.xlsx");

            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));
            //Fill User Details
            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));
        }

        [Test]                                                          //Execution part 2
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }

        [TearDown]                                                      //Method that is called immediatellz after test
        public void CleanUp()
        {
            //Closing the PropertiesCollection.driver
            PropertiesCollection.driver.Close();
            Console.WriteLine("Cloased the browser");
        }
    }
}
