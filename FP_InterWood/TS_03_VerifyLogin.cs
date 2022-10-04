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
    public class TS_03_VerifyLogin:GeneralMethodsClass
    {
        #region signInPageElements
        By userIcon = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[2]/div[1]/button/span/a/i");
        By userEmail = By.XPath("//*[@id=\"root\"]/main/div[4]/div/div/div/div[1]/form/div[1]/span/input");
        By userPassword = By.XPath("//*[@id=\"root\"]/main/div[4]/div/div/div/div[1]/form/div[2]/div/span/input");
        By signInButton = By.XPath("//*[@id=\"root\"]/main/div[4]/div/div/div/div[1]/form/button");
        #endregion
        
        public void SignInFunctionality(string email, string pass)
        {
            ClickableItem(userIcon);
            inputText(userEmail, email);
            inputText(userPassword, pass);
            ClickableItem(signInButton);
        }

    }
}
