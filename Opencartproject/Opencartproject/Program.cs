using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace Opencartproject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            excel.Application xlap=new excel.Application();
            excel.Workbook xwb = xlap.Workbooks.Open("C:\\Users\\Administrator\\exceldatanew.xlsx");
            excel.Worksheet xws = xwb.Sheets[1];
            excel.Range r1 = xws.UsedRange;
            Console.WriteLine(r1);

            for(int i = 2; i <= 5; i++)
            {

                String username, password;
                dynamic value = r1.Cells[1][i].value;
                username = value;
                password = r1.Cells[2][i].value;

                Console.WriteLine("Hello world welcome to c#");

                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://demo.opencart.com/");
                driver.FindElement(By.LinkText("My Account")).Click();
                driver.FindElement(By.LinkText("Login")).Click();
                driver.FindElement(By.Id("input-email")).SendKeys(username);
                driver.FindElement(By.Id("input-password")).SendKeys(password);
                driver.FindElement(By.XPath("//button[@type='submit']"));
                driver.Quit();

            }
        }
    }
}
