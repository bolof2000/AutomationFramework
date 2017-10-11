using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace framework
{
    [TestClass]
    public class InvalidUserNotLogin
    {
        [TestMethod]
        public void RunTest()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://127.0.0.1:8000/accounts/login/");
            var user = driver.FindElementById("id_username");
            user.SendKeys("wrongUsername");

            var pass = driver.FindElementById("id_password");
            pass.SendKeys("wrongPassword");

            driver.FindElementByXPath("html/body/div[1]/div/form/input[2]").Click();



        }
    }
}
