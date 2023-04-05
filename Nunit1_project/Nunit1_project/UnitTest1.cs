using Nunit1_project.page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Nunit1_project
{
    public class Tests

    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

        }

        [Test]
        public void Test1()
        {

            loginpageobject lp = new loginpageobject(driver);


            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            lp.clickonmyaccountlink();
            lp.clickonloginlink();
            lp.enterusername();
            lp.enterpassword();
            lp.clickonsubmit();

            //driver.FindElement(By.LinkText("My Account")).Click();
            //driver.FindElement(By.LinkText("Login")).Click();
            //driver.FindElement(By.Id("input-email")).SendKeys("vk@gmail.com");
            //driver.FindElement(By.Id("input-password")).SendKeys("vk");
            //driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.Quit();
            Assert.Pass();

        }
    }
}