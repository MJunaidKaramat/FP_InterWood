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

namespace FP_InterWood
{
    public class GeneralMethodsClass
    {
        public static IWebDriver driver;
        public GeneralMethodsClass()
        {
            //driver = null;
        }
        public GeneralMethodsClass(string browserName)
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
        public void landingPage(string u)
        {
            driver.Url = u;
           // driver.FindElement(By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[2]/div[1]/button/span/a/i")).Click();
        }
        public IWebElement findElement(By path)
        {   
            return driver.FindElement(path);
        }

        public void ClickableItem(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.Click(element).Build().Perform();
        }

        public void dropDownItemSelect(IWebElement drpDown, string value)
        {
            SelectElement dropDownMenu = new SelectElement(drpDown);
            dropDownMenu.SelectByValue(value);
        }
        public void inputText(IWebElement txtbox, string data)
        {
            txtbox.SendKeys(data);
        }
    }
}
