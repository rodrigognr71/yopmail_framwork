using AutomationWebBootcamp.src.code.factoryBrowser;
using AutomationWebBootcamp.src.code.page;
using AutomationWebBootcamp.src.code.test;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Yopmail.src.code.page;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Yopmail.src.code.test.yopmailTests
{
    [TestClass]
    public class YopmailTest : TestBaseYopmail
    {
        MainPage mainPage = new MainPage();
        InboxPage inboxPage = new InboxPage();
        private IWebElement iframeElement;

        [TestMethod]
        public void VerifySendMail()
        {
            string emailAddress = "esteamil12";
            string subject = "email test";
            string body = "sending a test email";

            //create email
            mainPage.emailTextBox.Click();
            mainPage.emailTextBox.SetText(emailAddress);
            mainPage.checkInboxButton.Click();

            //verify if email was created
            Assert.IsTrue(inboxPage.IsEmailDisplayed(emailAddress), "ERROR! The email was not created");

            //send email
            inboxPage.sendButton.Click();         
            iframeElement = driver.FindElement(By.Id("ifmail"));
            driver.SwitchTo().Frame(iframeElement);          
            inboxPage.messageToTextBox.SetText(emailAddress + "@yopmail.com");
            inboxPage.subjectTextBox.SetText(subject);
            inboxPage.messageBodyTextBox.SetText(body);
            inboxPage.sendEmailButton.Click();
            driver.SwitchTo().DefaultContent();

            //verify if the email was received
            inboxPage.refreshButton.Click();
            Thread.Sleep(1000);
            iframeElement = driver.FindElement(By.Id("ifinbox"));
            driver.SwitchTo().Frame(iframeElement);
            inboxPage.emailReceivedButton.Click();

            Assert.IsTrue(inboxPage.IsEmailReceived(subject),"ERROR! The email was not received");
        }
    }
}
