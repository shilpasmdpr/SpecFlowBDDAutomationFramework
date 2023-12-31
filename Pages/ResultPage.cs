﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class ResultPage
    {
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By channelName = By.XPath("(//a[@jsname='UWckNb'])[1]");

        public ChannelPage clickOnChannel()
        {
            driver.FindElement(channelName).Click();
            return new ChannelPage(driver);
        }
    }
}
