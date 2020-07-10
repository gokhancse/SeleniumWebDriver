using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    enum PropertyType
    {
        Name,
        Id,
        LinkText,
        CssName,
        ClassName
    }
    class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
    }
}
