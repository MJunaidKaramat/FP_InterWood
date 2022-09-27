﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;


namespace FP_InterWood
{
    public class SignUPClass:GeneralMethodsClass
    {
        
        #region ElementsOfSignUpPage
        By userIcon = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[2]/div[2]/div[1]/button/span/a/i");
        By createAccountButton = By.LinkText("Create an Account");
        By emailField = By.Name("customer.email");
        By passwordField = By.XPath("//input[@type='password']");
        By firstNameField = By.Name("customer.firstname");
        By lastNameField = By.Name("customer.lastname");
        By addressField = By.Name("address.street");
        By cityField = By.Name("address.city");
        By phoneField = By.Name("address.telephone");
        By termsCheck = By.XPath("//*[@id=\"root\"]/main/div[4]/div/div/div/div/form/div[2]/div[6]/label/input");
        By subscribeCheck = By.XPath("//*[@id=\"root\"]/main/div[4]/div/div/div/div/form/div[2]/div[7]/label");
        By CreateAccountSubmitButton = By.XPath("//button[text()='Create Account']");
        #endregion

        public void signUp()
        {
            

            IWebElement userIconF = findElement(userIcon);
            userIconF.Click();
            //IWebElement createAccountButtonF = findElement(createAccountButton);
            //IWebElement emailFieldF = findElement(emailField);
            //IWebElement passwordFieldF = findElement(passwordField);
            //IWebElement firstnameFieldF = findElement(firstNameField);
            //IWebElement lastnameFieldF = findElement(lastNameField);
            //IWebElement addressFieldF = findElement(addressField);
            //IWebElement cityFieldF = findElement(cityField);
            //IWebElement phoneFieldF = findElement(phoneField);
            //IWebElement termsCheckF = findElement(termsCheck);
            //IWebElement subscribeCheckF = findElement(subscribeCheck);
            //IWebElement CreateAccountSubmitButtonF = findElement(CreateAccountSubmitButton);

           // ClickableItem(userIconF);
            //ClickableItem(createAccountButtonF);
            //inputText(emailFieldF, "abc123@gmail.com");
            //inputText(passwordFieldF, "abc123@gmail");
            //inputText(firstnameFieldF, "abcdef");
            //inputText(lastnameFieldF, "xyz");

            
        }
    }
    
}
