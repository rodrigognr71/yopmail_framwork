﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWebBootcamp.src.code.control
{
    public class TextBox : Control
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public void SetText(String value)
        {
            FindControl();
            control.Clear(); 
            control.SendKeys(value);
        }
    }
}
