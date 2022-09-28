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
    public class SignUPClass:GeneralMethodsClass
    {
        
        #region ElementsOfSignUpPage
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
            ClickableItem(createAccountButton);
            ImplicitWait(10);
            inputText(emailField, "abc123@gmail.com");
            inputText(passwordField, "abc123@gmail");
            inputText(firstNameField, "abcdef");
            inputText(lastNameField, "xyz");
            inputText(addressField, "Lahore");
            dropDownItemSelect(cityField, "Lahore");
            inputText(phoneField, "0300-0123456");
            CheckBoxItem(termsCheck);
            CheckBoxItem(subscribeCheck);
            ClickableItem(CreateAccountSubmitButton);
        }
    }
    
}
