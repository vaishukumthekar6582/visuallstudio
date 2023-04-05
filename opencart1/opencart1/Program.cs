using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opencart1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello world welcome to c#");
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).SendKeys("vk@gmail.com");
            driver.FindElement(By.Id("input-password")).SendKeys("vk");
            driver.FindElement(By.XPath("//button[@type='submit']"));
            driver.Quit();
        }
    }
}
