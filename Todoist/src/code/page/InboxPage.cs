using AutomationWebBootcamp.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yopmail.src.code.page
{
    public class InboxPage
    {
        public Button sendButton = new Button(By.Id("newmail"));
        public TextBox messageToTextBox = new TextBox(By.XPath("//input[@id='msgto']"));
        public TextBox subjectTextBox = new TextBox(By.Id("msgsubject"));
        public TextBox messageBodyTextBox = new TextBox(By.Id("msgbody"));
        public Button sendEmailButton = new Button(By.Id("msgsend"));
        public Button refreshButton = new Button(By.Id("refresh"));
        public Button emailReceivedButton = new Button(By.XPath("//button[@class='lm']"));

        public bool IsEmailDisplayed(string emailName)
        {
            Label label = new Label(By.XPath("//div[@class='bname'][contains(text(),'" + emailName + "@yopmail.com')]"));
            return label.IsControlDisplayed();
        }

        public bool IsEmailReceived(string email)
        {
            Label emaiReceivedlLabel = new Label(By.XPath("//div[@class='lmfd']"));
            return emaiReceivedlLabel.IsControlDisplayed();
        }
    }
}
