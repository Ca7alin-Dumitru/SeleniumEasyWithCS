using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyWithCS.PageObjects
{
    public class PageObject
    {
        protected RemoteWebDriver driver;
        protected Actions actions;

        public PageObject(RemoteWebDriver driver)
        {
            this.driver = driver;
            actions = new Actions(driver);

        }
    }
}
