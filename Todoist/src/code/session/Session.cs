using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationWebBootcamp.src.code.factoryBrowser;

namespace AutomationWebBootcamp.src.code.session
{
    public class Session
    {
        //attributes of the same type
        private static Session instance = null;
        private IWebDriver browser;

        //private constructor
        private Session() 
        {
            browser = FactoryBrowser.Make("Chrome").Create();           
        }

        //public static method to global access
        public static Session Instance()
        { 
            if (instance == null) 
            {
                instance= new Session();
            }
            return instance;
        }

        //Close browser
        public void CloseBrowser()
        { 
            instance = null;
            browser.Quit();
        }

        public IWebDriver GetBrowser() => browser;
    }
}
