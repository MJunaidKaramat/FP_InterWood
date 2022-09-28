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

    public class landingPageClass : GeneralMethodsClass
    {
        #region landingPageObjects
        By userIcon = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[2]/div[1]/button/span/a/i");
        By cartIcon = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[2]/div[2]/a");
        By searchBox = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[1]/div/form/div[2]/span/input");
        By searchButton = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[1]/div/form/div[2]/button");
        #endregion
        public void signinSignUpButton()
        {
            ClickableItem(userIcon);
        }
        public void searchBoxField(string searchText)
        {
            ClickableItem(searchBox);
            inputText(searchBox, searchText);
        }
        public void searchBoxButton()
        {
            ClickableItem(searchButton);
        }
    }
}
