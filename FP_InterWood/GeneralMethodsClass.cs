using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace FP_InterWood
{
    public class GeneralMethodsClass
    {
        WebDriver driver;
        public GeneralMethodsClass(WebDriver driver)
        {
            this.driver = driver;
        }
        public IWebDriver browser(string browserName)
        {
            IWebDriver driver = null;
            if (browserName.Equals("chrome", StringComparison.InvariantCultureIgnoreCase))
            {
                driver = new ChromeDriver();

            }
            else if (browserName.Equals("edge", StringComparison.InvariantCultureIgnoreCase)) {

                driver = new EdgeDriver();
            }

            return driver;

        }

        public IWebElement findElement(By path, IWebDriver dr)
        {
            
            return dr.FindElement(path);
        }

        public void ClickableItem(By path, IWebDriver d)
        {
            IWebElement icon = findElement(path, d);
            icon.Click();
        }


    }
}
