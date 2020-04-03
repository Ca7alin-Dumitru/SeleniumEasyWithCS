using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using SeleniumEasyWithCS.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyWithCS
{
    [TestFixture]
    public class Tests : Program
    {
        [Test]
        public void verifySimpleFormDemoPageNegativeTests()
        {
            HomePage homePage = new HomePage(driver);
            homePage.StartPractisingOnSimpleFormDemo().
                singleInputFieldSection("").
                twoInputFieldsSection("", "");
            Assert.That(driver.FindElement(By.CssSelector("#display")).Text.Equals(""), Is.EqualTo(true), "The text is not the correct one!");
            Assert.That(driver.FindElement(By.CssSelector("#displayvalue")).Text.Equals("NaN"), Is.EqualTo(true), "The text is not the correct one!");
        }

        [Test]
        public void verifySimpleFormDemoPagePositiveTests()
        {
            HomePage homePage = new HomePage(driver);
            homePage.StartPractisingOnSimpleFormDemo().
                singleInputFieldSection("An automated message!").
                twoInputFieldsSection("1", "2");
            Assert.That(driver.FindElement(By.CssSelector("#display")).Text.Equals("An automated message!"), Is.EqualTo(true), "The text is not the correct one!");
            Assert.That(driver.FindElement(By.CssSelector("#displayvalue")).Text.Equals("3"), Is.EqualTo(true), "The text is not the correct one!");
        }
    }
    public class Program
    {
        public RemoteWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialise()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Navigate to SeleniumEasy page
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            Console.WriteLine("Opened URL");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Browser close!");
        }
    }
}
