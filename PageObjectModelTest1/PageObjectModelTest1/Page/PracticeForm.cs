
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.DOM;
using PageObjectModelTest1.Driver;
using WebDriver = PageObjectModelTest1.Driver.WebDriver;

namespace PageObjectModelTest1.Page
{
    public class PracticeForm
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));
        public IWebElement LastName => driver.FindElement(By.Id("lastName"));

        public IWebElement Email => driver.FindElement(By.Id("lastName"));
        public IWebElement Gender => driver.FindElement(By.Id("gender-radio-2"));
        public IWebElement Mobile => driver.FindElement(By.Id("userNumber"));

        public IWebElement Subjects => driver.FindElement(By.Id("subjectsContainer"));

        public IWebElement Hobbies => driver.FindElement(By.Id("hobbies-checkbox-2"));

        public IWebElement Button => driver.FindElement(By.Id("submit"));

        public void EnterName(string name)
        {
            FirstName.SendKeys(name);
        }

        public void EnterLastname(string name)
        {
            LastName.SendKeys(name);
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void SelectGender()
        {
            Gender.Click();
        }

        public void EnterMobile(string mobile)
        {
            Mobile.SendKeys(mobile);
        }

        public void EnterSubjects(string name)
        {           
            Subjects.Click();
            Subjects.SendKeys(name);
            Subjects.Click();
        }

        public void SelectHobbies()
        {
            Hobbies.Click();
        }

        public void PressButton()
        {
            Button.Submit();
        }
    }
}
