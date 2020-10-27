using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
       static IWebDriver driver = new ChromeDriver();
        
        [ClassInitialize]
        public static void Initialize(TestContext test)
        {
            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("URL Opened");
        }

        [TestMethod]
        public void ExeuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            // Initial

            SeleniumSetMethods.EnterText(driver, "Initial", "N", "Name");

            //First Name
            SeleniumSetMethods.EnterText(driver, "FirstName", "Ramesh", "Name");

            //MiddleName
            SeleniumSetMethods.EnterText(driver, "MiddleName", "Nagendrappa", "Name");

            //Click

            SeleniumSetMethods.Click(driver,"Save","Name");

        }

        [TestMethod]
        public void Login()
        {
            
           IWebElement username  = driver.FindElement(By.Id("username"));
            username.SendKeys("neetprodins1");
            Console.WriteLine("Username Entered");

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("Password1");
            Console.WriteLine("Password ENtered");

           IWebElement signin = driver.FindElement(By.Id("mainButton"));
           signin.Click();
            Console.WriteLine("Signin Button Clicked");
        }
        [TestMethod]
        public void NextTest1()
        {
            Console.WriteLine("NextTest 1");

        }

        [TestMethod]
        public void NextTest2()
        {
            Console.WriteLine("NextTest 2");

        }

        [TestMethod]
        public void NextTest3()
        {
            Console.WriteLine("NextTest 3");

        }

        [TestCleanup]

        public void Cleanup()
        {
            //driver.Close();
            //Console.WriteLine("Browser Closed");
        }
    }
}
