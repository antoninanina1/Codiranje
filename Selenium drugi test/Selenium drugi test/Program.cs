using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_drugi_test
{
    public class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
           


        }

        [SetUp]
        public void Instalacija()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            IWebElement username = driver.FindElement(By.Id("user-name"));
            username.SendKeys("standard_user");

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");

            IWebElement LoginButton = driver.FindElement(By.Id("login-button"));

            LoginButton.Submit();
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }

    }
}
