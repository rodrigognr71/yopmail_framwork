using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationWebBootcamp.src.code.control;

namespace AutomationWebBootcamp.src.code.page
{
    public class MainPage
    {
        public TextBox emailTextBox = new TextBox(By.Id("login"));
        public Button checkInboxButton = new Button(By.XPath("//button[@title=\"Check Inbox @yopmail.com\"]"));
    }
}
