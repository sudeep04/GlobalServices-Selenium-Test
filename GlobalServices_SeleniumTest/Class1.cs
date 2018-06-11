using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SeleniumTest
{
    [TestFixture]
    public class CheckDevServerHomePage
    {

        [Test]
        public void site_header_is_on_home_page()
        {
            IWebDriver browser = new FirefoxDriver();
            //Firefox's proxy driver executable is in a folder already
            //  on the host system's PATH environment variable.
            browser.Navigate().GoToUrl("http://dev.cmacspro.com");
            IWebElement header = browser.FindElement(By.Id("site - header"));
    
            Assert.True(header.Displayed);
            browser.Close();
        }
    }
}