using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            //UserName
            //txtUserName.SendKeys(userName);
            ////Password
            //txtPassword.SendKeys(password);
            ////Click button
            //btnLogin.Submit();

         //part 11
            txtUserName.EnterText(userName);

            txtPassword.EnterText(password);

            //btnLogin.Clicks(); // not working
            btnLogin.Submit(); //this way works

            //Return the page object
            return new EAPageObject();
        }
    }
}
