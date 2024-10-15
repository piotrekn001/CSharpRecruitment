
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Reflection;

namespace dotNetTestsTemplate.tests
{
    public class Tests
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        [DeploymentItem("selenium-manager", "selenium-manager")]

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            wait = new(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void Test1()
        {           
            driver.Navigate().GoToUrl("https://www.spyro-soft.com");
        }

        [TearDown]       
        public void Teardown() 
        {
            driver.Close();
            driver.Quit();            
        }
    }
}