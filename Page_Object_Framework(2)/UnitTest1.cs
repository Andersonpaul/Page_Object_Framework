using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;



namespace Page_Object_Framework_2_
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        string url;

        [TestInitialize]
        public void setup()
        {
            driver = new FirefoxDriver();
            url = "http://62.173.32.45/CIPGHarmonized/Login.aspx";
        }
        [TestMethod]
        public void TestMethod1()
        {
            
            driver.Navigate().GoToUrl(url);
            
            Home_page.Login_username(driver).SendKeys("");
            Home_page.Login_password(driver).SendKeys("password");
            Home_page.Login(driver).Click();
        }

    }
}
