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
            var chromeDriver = new ChromeDriver(options);
            chromeDriver.Navigate().GoToUrl("https://reddit.com");
                Console.WriteLine("Hello I'm reddit");
        }
    }
}
