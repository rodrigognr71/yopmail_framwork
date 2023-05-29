using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationWebBootcamp.src.code.session;
using OpenQA.Selenium.Support.UI;
using AutomationWebBootcamp.src.code.factoryBrowser;

namespace AutomationWebBootcamp.src.code.test
{
    [TestClass]
    public class TestBaseYopmail
    {
        protected static IWebDriver driver;
        public static void SetDriver(IWebDriver driverInstance)
        {
            driver = driverInstance;
        }

        [TestInitialize]
        public void OpenBrowser()
        {
            Session.Instance().GetBrowser().Navigate().GoToUrl("https://yopmail.com/");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();
        }
    }
}
