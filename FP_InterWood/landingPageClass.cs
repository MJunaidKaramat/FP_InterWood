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

    public class landingPageClass : GeneralMethodsClass
    {
        #region landingPageObjects
        By userIcon = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[2]/div[1]/button/span/a/i");
        By cartIcon = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[2]/div[2]/a");
        By searchBox = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[1]/div/form/div[2]/span/input");
        By searchButton = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[1]/div/form/div[2]/button");
        By navItem1 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[1]/a");
        By navItem2 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[2]/a");
        By navItem3 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[3]/a");
        By navItem4 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[4]/a");
        By navItem5 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[5]/a");
        By navItem6 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[6]/a");
        By navItem7 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[7]/a");
        By navItem8 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[8]/a");
        By navItem9 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[9]/a");
        By navItem10 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[10]/a");
        By navItem11 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[11]/a");
        By navItem12 = By.XPath("//*[@id=\"root\"]/main/div[3]/div/div/div/nav/ul/li[12]/a");
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
        public void ScrollHomePage()
        {
            scrollPageDown();
            scrollPageUp();
        }
        public void cartStatus()
        {
            ClickableItem(cartIcon);
        }
        public void navBarScrolling()
        {
            hoverAction(navItem1);
            hoverAction(navItem2);
            hoverAction(navItem3);
            hoverAction(navItem4);
            hoverAction(navItem5);
            hoverAction(navItem6);
            hoverAction(navItem7);
            hoverAction(navItem8);
            hoverAction(navItem9);
            hoverAction(navItem10);
            hoverAction(navItem11);
            hoverAction(navItem12);
        }


    }
}
