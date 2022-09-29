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
    public class FilterClass
    {
        #region filterElementPaths
        By filterButton = By.XPath("//*[@id=\"root\"]/main/div[4]/article/section[1]/div/div/ul/li[1]/a");
        By clearFilterButton = By.XPath("//*[@id=\"root\"]/aside[2]/div[1]/span/div[2]/button/span");
        #endregion
    }
}
