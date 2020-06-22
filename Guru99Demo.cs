using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99Demo
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://www.google.com.ua";
        }

        [Test]
        public void CssDemo()
        {
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            
            IWebElement link = driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click();
        }

        [Test]
        public void TestG()
        {
            driver.Url = "http://www.google.com.ua";
            IWebElement input = driver.FindElement(By.Name("q"));
            input.SendKeys("tony stark");
            input.SendKeys(Keys.Enter);                
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}