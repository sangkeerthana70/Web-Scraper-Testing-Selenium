using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace OpenSimpleWebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-gpu");
            var chromeDriver = new ChromeDriver(options);//create chrome driver
            chromeDriver.Navigate().GoToUrl("https://google.com");//navigate to reddit.com
                Console.WriteLine("Hello I'm google");

             chromeDriver.FindElementByXPath("//*[@id=\"lst-ib\"]").Click();//grab the X-Path to navigate to an element in the reddit page, find it and click on it
             chromeDriver.Keyboard.SendKeys("cats");
             chromeDriver.Keyboard.SendKeys(Keys.Enter);//should take you to a new page
        }
    }
}
