using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace FP_InterWood
{
    public class TS_01_VerifyURLWorkingWithBrowsers:GeneralMethodsClass
    {
        By mainLogo = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[1]/a/img");
        public void chromeBrowser(string browser, string link)
        {
            BrowserSelection(browser);
            landingPage(link);
            
        }
        public void edgeBrowser(string browser, string link)
        {
            BrowserSelection(browser);
            landingPage(link);
        }

    }
}
