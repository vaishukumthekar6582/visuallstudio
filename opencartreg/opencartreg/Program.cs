using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace opencartreg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                excel.Application xlap = new excel.Application();
                excel.Workbook xwb = xlap.Workbooks.Open("C:\\Users\\Administrator\\Documents\\python project\\registrationdataimport.xlsx");
                excel.Worksheet xws = xwb.Sheets[1];
                excel.Range r1 = xws.UsedRange;
                Console.WriteLine(r1);

                for (int i = 2; i <= 5; i++)
                {

                    String firstname,lastname,username, password;

                    firstname = r1.Cells[1][i].value;
                    lastname = r1.Cells[2][i].value;
                    username = r1.Cells[3][i].value;
                    password = r1.Cells[4][i].value;
                    
                    Console.WriteLine("Hello world welcome to c#");

                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://demo.opencart.com/");
                    driver.FindElement(By.LinkText("My Account")).Click();
                    driver.FindElement(By.LinkText("Register")).Click();
                    driver.FindElement(By.Id("input-firstname")).SendKeys(firstname);
                    driver.FindElement(By.Id("input-lastname")).SendKeys(lastname);
                    driver.FindElement(By.Id("input-email")).SendKeys(username);
                    Thread.Sleep(100);
                    driver.FindElement(By.Id("input-password")).SendKeys(password);
                    Thread.Sleep(100);
                    driver.FindElement(By.Name("agree")).Click();
                    Thread.Sleep(100);
                    driver.FindElement(By.XPath("//button[@type='submit']"));
                    Thread.Sleep(50);
                    driver.Quit();

                }
            
        }
    }

}
    

