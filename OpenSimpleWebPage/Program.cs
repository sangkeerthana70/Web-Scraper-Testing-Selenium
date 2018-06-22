using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace OpenSimpleWebPage
{
    class Program
    {


        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-gpu");
            var chromeDriver = new ChromeDriver(options);//create chrome driver
            chromeDriver.Navigate().GoToUrl("https://google.com");//navigate to google.com
                Console.WriteLine("Hello I'm Google");



            chromeDriver.FindElementByXPath("//*[@id=\"lst-ib\"]").Click();//grab the X-Path to navigate to an element in the google page, find it and click on it
            chromeDriver.Keyboard.SendKeys("mountain bike");
            chromeDriver.Keyboard.SendKeys(Keys.Enter);//should take you to a new page

            chromeDriver.FindElementByXPath("//*[@id=\"hdtb-msb-vis\"]/div[2]/a").Click();
            var items = chromeDriver.FindElementsByXPath("//*[@id=\"rso\"]/div[1]/div/div[*]/div/div[2]/div/div[1]/a");//generates a list of searched shopping items.
            Console.WriteLine(items.Count);//verify number of search items.

            foreach (var item in items)
            {
                Console.WriteLine(item.Text);
            }

        }
    }
}
