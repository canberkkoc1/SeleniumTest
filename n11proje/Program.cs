using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using NUnit.Framework;


namespace n11proje
{
    class Program
    {
        IWebDriver driver = new FirefoxDriver();

        [SetUp]
        public void Initialize()
        {
           
            string link = @"https://www.n11.com/";
            driver.Navigate().GoToUrl(link);
        }
        [Test]
        public void ETest()
        {
            try
            {
                SMethods.Click(driver, "//*[@id='header']/div/div/div[2]/div[2]/div[2]/div/div/a[1]", "XPath");
                System.Threading.Thread.Sleep(10000);
                SMethods.EText(driver, "email", "testtest.cnbrk@gmail.com", "Id");
                SMethods.EText(driver, "password", "123456yhN", "Name");
                System.Threading.Thread.Sleep(10000);
                SMethods.Click(driver, "green_flat", "ClassName");
                System.Threading.Thread.Sleep(10000);
                SMethods.EText(driver, "searchData", "samsung", "Id");
                SMethods.Click(driver, "searchBtn", "ClassName");
                SMethods.Check(driver, "pro");
                System.Threading.Thread.Sleep(1000);
                SMethods.Click(driver, "/html/body/div[1]/div[3]/div/div/div[2]/div[4]/a[2]", "XPath");
                System.Threading.Thread.Sleep(1000);
                SMethods.Click(driver, "/html/body/div[1]/div[3]/div/div/div[2]/section[1]/div[2]/ul/li[3]/div/div[1]/span", "XPath");
                System.Threading.Thread.Sleep(1000);
                SMethods.Click(driver, "/html/body/div[1]/header/div/div/div[2]/div[2]/div[2]/div[1]/a[1]", "XPath");
                System.Threading.Thread.Sleep(1000);
                SMethods.Click(driver, "/html/body/div[1]/header/div/div/div[2]/div[2]/div[2]/div[1]/a[2]","XPath");
                System.Threading.Thread.Sleep(1000);
                SMethods.Click(driver, "#myAccount > div.accMenu > div.accMenu-cover > div.accNav > ul > li:nth-child(5) > a", "CssSelector");
                System.Threading.Thread.Sleep(1000);                
                SMethods.Click(driver, "/html/body/div[1]/div[3]/div/div[2]/div[3]/ul/li[1]/div/a/h4","XPath");
                System.Threading.Thread.Sleep(1000);
                //SMethods.Check(driver, "emptyWatchList hiddentext");
                //System.Threading.Thread.Sleep(1000);
                SMethods.Click(driver, "/html/body/div[1]/div[3]/div/div[2]/div[3]/div[1]/div[2]/ul/li/div/div[3]/span", "XPath");
                System.Threading.Thread.Sleep(1000);
                SMethods.Click(driver, "/html/body/div[4]/div/div/span", "XPath");
                System.Threading.Thread.Sleep(1000);
                


            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element bulunamadı!!!");
            }
           









        }
        [TearDown]
        public void Clean()
        {
            driver.Close();
        }
    }
}

