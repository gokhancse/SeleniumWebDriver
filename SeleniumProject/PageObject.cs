using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class PageObject // Login sonrasında açılan sayfa
    {
        public PageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //[FindsBy(How = How.Id,Using = "searchData")]
        //public IWebElement txtsearchData { get; set; }

        [FindsBy(How = How.ClassName, Using = "desktopOldAutosuggestTheme-input")] // Sayfa nesnelerini POM yapısıyla alıyorum
        public IWebElement txtsearch { get; set; }

        [FindsBy(How = How.ClassName, Using = "SearchBoxOld-buttonContainer")] 
        public IWebElement btnsearch { get; set; }

        [FindsBy(How = How.LinkText, Using = "2")]
        public IWebElement btnNavigate { get; set; }

        //[FindsBy(How = How.Id, Using = "Save")]
        //public IWebElement btnSave { get; set; }

        public void SearchItem(string itemname) // Ürünün aratılması
        {
            Thread.Sleep(5000);
            txtsearch.EnterText(itemname);
            btnsearch.ClickItem();
            //iconsearch.SendKeys(_item);
            //PropertiesCollection.driver.FindElement(By.XPath("//span[contains(@class,'searchBtn')]"));
        }

        public SecondPage NavigateSecondPage() // Seçilen ürünün açıldığı sayfa 
        {
            Thread.Sleep(5000);
            btnNavigate.ClickItem();
            return new SecondPage();

        }

    }
}

