using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Reusables
{
    public class Class1
    {
        IWebDriver driver;
        public void Class1(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Login(string username, string password)
        {
            driver.FindElement(By.Id("Login1_UserName")).Clear();
            driver.FindElement(By.Id("Login1_UserName")).SendKeys(username);
            driver.FindElement(By.Id("Login1_Password")).SendKeys(password);
        }
    }
}
