using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumEasyWithCS.PageObjects
{
    public class HomePage : PageObject
    {

        IWebElement btnStartPractising => driver.FindElementById("btn_basic_example");
        IWebElement btnSimpleFormDemo => driver.FindElementByXPath("//a[@class='list-group-item'][contains(text(),'Simple Form Demo')]");

        public HomePage(RemoteWebDriver driver) : base(driver) {}

        public SimpleFormDemoPage StartPractisingOnSimpleFormDemo()
        {
            btnStartPractising.Click();
            Thread.Sleep(3000);
            actions.Click(btnSimpleFormDemo).Build().Perform();

            return new SimpleFormDemoPage(driver);
        }
    }
}