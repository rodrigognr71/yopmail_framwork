using AutomationWebBootcamp.src.code.test;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWebBootcamp.src.code.factoryBrowser
{
    public class Chrome : IBrowser
    {

        public IWebDriver driver;

    public IWebDriver Create()
        {
            Console.WriteLine("setup");
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path + "/resourxes/driver/chromedriver.exe");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            TestBaseYopmail.SetDriver(driver);
            return driver;
            
        }
    }
}
