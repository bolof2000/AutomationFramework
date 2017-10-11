using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace framework
{
    [TestClass]
    public class ValidUserCanSuccessfullyLogin
    {
        [TestMethod]
        public void RunTest()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://127.0.0.1:8000/accounts/login/");
            var user = driver.FindElementById("id_username");
            user.SendKeys("bolof2000");

            var pass = driver.FindElementById("id_password");
            pass.SendKeys("Dammy2k100");

            driver.FindElementByXPath("html/body/div[1]/div/form/input[2]").Click();

            var error = driver.FindElementsByXPath("html/body/div[1]/div/h1");
            Assert.IsTrue(error.,"not successful")
         
           



           

        }
    }
}
