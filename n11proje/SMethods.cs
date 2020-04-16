using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace n11proje
{
    class SMethods
    {
        public static void EText(IWebDriver driver, string  e, string v,string et)
        {
           if (et == "Id")
                driver.FindElement(By.Id(e)).SendKeys(v);
           if (et == "Name")
                driver.FindElement(By.Name(e)).SendKeys(v);


        }
        public static void Click(IWebDriver driver , string e , string et)
        {
            if (et == "XPath")
                driver.FindElement(By.XPath(e)).Click();
            if (et == "ClassName")
                driver.FindElement(By.ClassName(e)).Click();
            if (et == "CssSelector")
                driver.FindElement(By.CssSelector(e)).Click();
        }
        public static void Check(IWebDriver driver,string n)
        {
            
            if (driver.FindElement(By.ClassName(n)) == driver.FindElement(By.ClassName(n)))
                Console.WriteLine("Arama işlemi başarısız");
            else
            {
                Console.WriteLine("Arama işlem başarılı");
            }



        }
        



        
    }
}
