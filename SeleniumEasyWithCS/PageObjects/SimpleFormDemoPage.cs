using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyWithCS.PageObjects
{
    public class SimpleFormDemoPage : PageObject
    {
        //these webelements are for Single Input Field
        private IWebElement pleaseEnterYourMessageField => driver.FindElementByCssSelector("input#user-message");
        private IWebElement showMessageButton => driver.FindElementByXPath("//form[@id='get-input']/button");

        //these webelements are for Two Input Fields
        private IWebElement enterValueForAField => driver.FindElementByXPath("//form[@id='gettotal']/div[1]/input");
        private IWebElement enterValueForBField => driver.FindElementByXPath("//form[@id='gettotal']/div[2]/input");
        private IWebElement getTotalButton => driver.FindElementByXPath("//form[@id='gettotal']/button");

        public SimpleFormDemoPage(RemoteWebDriver driver) : base(driver) {}

    public SimpleFormDemoPage singleInputFieldSection(string message)
        {
            this.pleaseEnterYourMessageField.SendKeys(message);
            this.showMessageButton.Click();
            return new SimpleFormDemoPage(driver);
        }
    public SimpleFormDemoPage twoInputFieldsSection(string valueA, string valueB)
        {
            this.enterValueForAField.SendKeys(valueA);
            this.enterValueForBField.SendKeys(valueB);
            this.getTotalButton.Click();
            return new SimpleFormDemoPage(driver);
        }
    }
}
