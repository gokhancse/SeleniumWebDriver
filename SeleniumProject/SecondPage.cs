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
    class SecondPage
    {
        public SecondPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "page-2 ")]
        public IWebElement btnNavigate { get; set; }

        [FindsBy(How = How.Id, Using = "heartWrapper")]
        public IWebElement btnFav { get; set; }

        [FindsBy(How = How.ClassName, Using = "carousel-lazy-item")]
        public IWebElement btnSepeteEkle { get; set; }

        public SepeteEkle NavigateSecondPage()
        {
            Thread.Sleep(5000);
            btnNavigate.ClickItem();
            return new SepeteEkle();
        }

        public SepeteEkle SepeteEkle()
        {
            Thread.Sleep(5000);
            btnFav.ClickItem(); //Favorilere eklendi
            btnSepeteEkle.ClickItem(); //Sepete Eklendi
            return new SepeteEkle();
        }

    }
}
