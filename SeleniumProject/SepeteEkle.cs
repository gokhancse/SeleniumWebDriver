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
    class SepeteEkle
    {
        public SepeteEkle()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

       

    }
}
