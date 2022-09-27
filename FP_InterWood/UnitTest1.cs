using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace FP_InterWood
{
    [TestClass]
    public class MainClass: GeneralMethodsClass
    {
        IWebDriver webDriver ;
        public string url = "https://interwood.pk/";
        [TestMethod]
        public void BrowserInitializationMethod()
        {
            webDriver = browser("chrome");
            webDriver.Manage().Window.Maximize();
            webDriver.Url = url;
        }
        #region SignUpMethodElements
        By userIcon = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[2]/div[1]/button/span/a/i");

        #endregion
        [TestMethod]
        public void SignUpMethod()
        {
            ClickableItem(userIcon, webDriver);
        }
    }
}
