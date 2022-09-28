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
    public class SignInClass:GeneralMethodsClass
    {
        #region signInPageElements
        By userEmail = By.XPath("//*[@id=\"root\"]/main/div[4]/div/div/div/div[1]/form/div[1]/span/input");
        By userPassword = By.XPath("//*[@id=\"root\"]/main/div[4]/div/div/div/div[1]/form/div[2]/div/span/input");
        By signInButton = By.XPath("//*[@id=\"root\"]/main/div[4]/div/div/div/div[1]/form/button");
        #endregion
        
        public void signIn()
        {
            inputText(userEmail, "abc123@gmail.com");
            inputText(userPassword, "abc123@gmail");
            ClickableItem(signInButton);
        }
    }
}
