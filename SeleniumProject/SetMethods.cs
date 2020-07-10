using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SeleniumProject
{
    public static class SetMethods
    {
        // Extension metodunun uygulanması
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
           
        }
        //Buton, class name vb elementlerin tıklanması metodu
        public static void ClickItem(this IWebElement element) // Page object modellerinden çağırılacak
        {
            Thread.Sleep(5000);
            element.Click();
        }

        //dropdown seçimi
        //public static void SelectDropDown(this IWebElement element, string value)
        //{
        //    new SelectElement(element).SelectByText(value);
        //}

    }
}
