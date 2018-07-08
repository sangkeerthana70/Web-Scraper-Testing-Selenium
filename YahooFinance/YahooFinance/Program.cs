﻿using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
//using System.Collections.Generic;



namespace YahooFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-gpu");
            options.AddArguments("disable-popup-blocking");//to disable pop-up blocking

            var chromeDriver = new ChromeDriver(options);//create chrome driver
            //var wait = new chromeDriverWait(chromeDriver, TimeSpan.FromSeconds(20));

            chromeDriver.Navigate().GoToUrl("https://login.yahoo.com/");//navigate to google.com
            Console.WriteLine("Hello I'm in yahoo finance");

            chromeDriver.Manage().Window.Maximize();//maximizes the window
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);//implicitly wait until the next search element is found
            chromeDriver.FindElement(By.Id("login-username")).SendKeys("asangeethu@yahoo.com");
            chromeDriver.FindElement(By.Id("login-signin")).Click();
            //implicitly wait until the next search element is found
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            chromeDriver.FindElement(By.Id("login-passwd")).SendKeys("@nuk1978");
            chromeDriver.FindElement(By.Id("login-signin")).Click();
            //implicitly wait until the next search element is found
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            chromeDriver.Url = ("https://finance.yahoo.com/portfolio/p_1/view/v1");
            //chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Hello I'm here");
            var closePopup = chromeDriver.FindElementByXPath("//dialog[@id = '__dialog']/section/button");
            closePopup.Click();
            // chromeDriver.FindElementByXPath("//*[@id=\"fin-tradeit\"]/div[2]/div/div/div[2]/button[2]").Click();//click on the pop-up window using X-path to disable it.

            Console.WriteLine("Hello I'm here2");
            var items = chromeDriver.FindElementsByXPath("//*[@id=\"main\"]/section/section[2]/div[2]/table/tbody/tr[*]/td[*]");
            Console.WriteLine("Hello I'm here3");

            foreach (var item in items)
            {
                Console.WriteLine("My watchlist : " + item.Text);
            }
        }
    }
}
