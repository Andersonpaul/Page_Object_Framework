using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Page_Object_Framework_2_
{
    class Home_page
    {
       private static IWebElement element;
        public static IWebElement Login_username(IWebDriver driver)
        {
            element = driver.FindElement(By.Id("Login1_UserName"));
            return element;
        }

        public static IWebElement Login_password(IWebDriver driver)
        {
            element = driver.FindElement(By.Id("Login1_Password"));
            return element;
        }

        public static IWebElement Login(IWebDriver driver)
        {
            element = driver.FindElement(By.Id("Login1_LoginButton"));
            return element;
        }
    }
}
