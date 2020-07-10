using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumProject
{
    [TestFixture]
    class Program
    {
        //Reference for web browser
        IWebDriver driver = new ChromeDriver();



        static void Main(string[] args)
        {
            //Reference for web browser
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://www.google.com");
            //IWebElement element = driver.FindElement(By.Name("q"));
            //element.SendKeys("executeautomation");
            //driver.Close();

        }
        [TestFixtureSetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://giris.hepsiburada.com");
        }

        [Test]
        public void TestCase1() // Login test case
        {
            LoginPage loginpage = new LoginPage();
            PageObject redirectedpage = loginpage.Login("gokhanselale92@gmail.com", "1234567TC");
            Thread.Sleep(1000);
           
            try
            {
                Assert.AreEqual(driver.Title,String.Empty);
            }
            catch (Exception)
            {

                throw;
            }
            //PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            redirectedpage.SearchItem("samsung");
        }

        [Test]
        public void TestCase2() // Login sonrasında açılan sayfadan seçilen ürüne yönlendirme
        {
            PageObject pageobject = new PageObject();
            SecondPage secondpage = pageobject.NavigateSecondPage();
            Thread.Sleep(1000);
            //PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void TestCase3() //
        {
            SecondPage secondpage = new SecondPage();
            SepeteEkle favpage = secondpage.SepeteEkle();
            Thread.Sleep(1000);

            //PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }


        //[TearDown]
        //public void CleanUp()
        //{
        //    driver.Close();
        //}

    }
}
