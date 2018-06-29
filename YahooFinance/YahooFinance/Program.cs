using System;
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
            options.AddArguments("disable-popup-blocking");//to disable pop-up blocking

            chromeDriver.FindElementByXPath("//*[@id=\"uh\"]/header/ul[2]/li[3]/a").Click();
        }
    }
}
