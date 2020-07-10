using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "username")]//email
        public IWebElement txtemail { get; set; }

        [FindsBy(How = How.Name, Using = "password")]//pass
        public IWebElement txtpassword { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]//loginbutton
        public IWebElement btnLogin { get; set; }


        //login function
        public PageObject Login(string _username, string _password)
        {
            txtemail.EnterText(_username);
            txtpassword.EnterText(_password);
            //Click Button
            btnLogin.ClickItem();
            //return the redirected page
            return new PageObject(); // Açılacak sayfayı new page object ile return ediyorum

        }

    }
   

}
