using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit1_project.page
{
    public class loginpageobject 
    {
        private IWebDriver driver;
        public loginpageobject(IWebDriver driver1) 
        {
            driver = driver1;
        }
        public void clickonmyaccountlink()
        {
            driver.FindElement(By.LinkText("My Account")).Click();
        }
        public void clickonloginlink()
        {
            driver.FindElement(By.LinkText("Login")).Click();
        }
        public void enterusername() 
        {
            driver.FindElement(By.Id("input-email")).SendKeys("vk@gmail.com");
        }
        public void enterpassword()
        {
            driver.FindElement(By.Id("input-password")).SendKeys("vk");
        }
        public void clickonsubmit()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }
    }
}
