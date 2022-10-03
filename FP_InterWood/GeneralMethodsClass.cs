using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace FP_InterWood
{
    public class GeneralMethodsClass
    {
        public static IWebDriver driver;
        public GeneralMethodsClass()
        {
            //driver = null;
        }
        public void BrowserSelection(string browserName)
        {
            if (browserName.Equals("chrome", StringComparison.InvariantCultureIgnoreCase))
            {
                driver = new ChromeDriver();
            }
            else if (browserName.Equals("edge", StringComparison.InvariantCultureIgnoreCase))
            {
                driver = new EdgeDriver();
            }
            driver.Manage().Window.Maximize();
            
        }
        public void closeBrowser()
        {
            driver.Close();
        }
        public void landingPage(string u)
        {
            driver.Url = u;
        }
        public IWebElement findElement(By path)
        {   
            return driver.FindElement(path);
        }

        public void ClickableItem(By path)
        {
            IWebElement element = ExplicitWaitElementIsVisible(path);
            //element.Click();
            Actions action = new Actions(driver);
            action.Click(element).Build().Perform();
        }
        public void CheckBoxItem(By path)
        {
            IWebElement element = ExplicitWaitElementIsVisible(path);
            //element.Click();
            Actions action = new Actions(driver);
            action.Click(element).Build().Perform();
        }

        public void dropDownItemSelect(By path, string value)
        {
            IWebElement drpDown = findElement(path);
            SelectElement dropDownMenu = new SelectElement(drpDown);
            dropDownMenu.SelectByValue(value);
        }
        public IWebElement returnElement(By path)
        {
            return findElement(path);
        }
        public void inputText(By path, string data)
        {
            IWebElement txtBox = findElement(path);
            txtBox.SendKeys(data);
        }
        public void ImplicitWait(int i)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(i);
        }
        public IWebElement ExplicitWaitElementIsVisible(By path)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(path));
        }
        public void scrollPageDown()
        {
            IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
            for (int i = 0; i < 1000; i++)
            {
                scroller.ExecuteScript("window.scrollBy(0," + i + ")", "");
            }
        }
        public void scrollToElement(By path)
        {
            IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
            IWebElement detectedElement = ExplicitWaitElementIsVisible(path);
            scroller.ExecuteScript("arguments[0].scrollIntoView(true);", detectedElement);
        }
        public void scrollPageUp()
        {
            IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
            scroller.ExecuteScript("window.scrollTo(0, document." + "head" + ".scrollHeight);");
        }
        public void hoverAction(By path)
        {
            IWebElement webElement = findElement(path);
            Actions action = new Actions(driver);
            action.MoveToElement(webElement).Build().Perform();
        }
        public void scrollToElementClick(By path)
        {
            IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
            IWebElement detectedElement = ExplicitWaitElementIsVisible(path);
            scroller.ExecuteScript("arguments[0].scrollIntoView(true);", detectedElement);
            ClickableItem(path);
        }
        public void switchToChildFrame()
        {

            var prntWindow = driver.WindowHandles[0];
            var cldWindow = driver.WindowHandles[1];
            driver.SwitchTo().Frame(cldWindow);

        }
    }
}
