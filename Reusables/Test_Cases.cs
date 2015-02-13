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
    class Test_Cases
    {
        public IWebDriver driver;
        public void Test_Cases(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void test()
        {
            Class1 testing = new Class1(driver);
            testing.Login(TestConstants.empty_username, TestConstants.empty_password);
            testing.Login(TestConstants.wrong_username, TestConstants.wrong_password);
            testing.Login(TestConstants.wrong_username, TestConstants.empty_password);
            testing.Login(TestConstants.username, TestConstants.empty_password);
            testing.Login(TestConstants.username, TestConstants.password);

        }
    }
}
