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
    public class TS_02_VerifySignUp:GeneralMethodsClass
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

        public void TC02_SignUpWithValidCredentials(string eF, string pF, string fNF, string lNF, string aF, 
        string cF, string phF)
        {
            ClickableItem(userIcon);
            ClickableItem(createAccountButton);
            ImplicitWait(10);
            inputText(emailField, eF);
            inputText(passwordField, pF);
            inputText(firstNameField, fNF);
            inputText(lastNameField, lNF);
            inputText(addressField, aF);
            dropDownItemSelect(cityField, cF);
            inputText(phoneField, phF);
            CheckBoxItem(termsCheck);
            CheckBoxItem(subscribeCheck);
            ClickableItem(CreateAccountSubmitButton);
        }
        public void TC03_SignUpWithInvalidCredentials(string eF, string pF, string fNF, string lNF, string aF,
        string cF, string phF)
        {
            ClickableItem(userIcon);
            ClickableItem(createAccountButton);
            ImplicitWait(10);
            inputText(emailField, eF);
            inputText(passwordField, pF);   
            inputText(firstNameField, fNF);
            inputText(lastNameField, lNF);
            inputText(addressField, aF);
            dropDownItemSelect(cityField, cF);
            inputText(phoneField, phF);
            CheckBoxItem(termsCheck);
            CheckBoxItem(subscribeCheck);
            ClickableItem(CreateAccountSubmitButton);

        }

        public void TC04_SignUpButtonClickable(string eF, string pF, string fNF, string lNF, string aF,
        string cF, string phF)
        {
            ClickableItem(userIcon);
            ClickableItem(createAccountButton);
            ImplicitWait(10);
            inputText(emailField, eF);
            inputText(passwordField, pF);
            inputText(firstNameField, fNF);
            inputText(lastNameField, lNF);
            inputText(addressField, aF);
            dropDownItemSelect(cityField, cF);
            inputText(phoneField, phF);
            CheckBoxItem(termsCheck);
            CheckBoxItem(subscribeCheck);
            ClickableItem(CreateAccountSubmitButton);
        }

        public void TC05_SignUpWithoutAcceptingTerms(string eF, string pF, string fNF, string lNF, string aF,
        string cF, string phF)
        {
            ClickableItem(userIcon);
            ClickableItem(createAccountButton);
            ImplicitWait(10);
            inputText(emailField, eF);
            inputText(passwordField, pF);
            inputText(firstNameField, fNF);
            inputText(lastNameField, lNF);
            inputText(addressField, aF);
            dropDownItemSelect(cityField, cF);
            inputText(phoneField, phF);
            ClickableItem(CreateAccountSubmitButton);
        }
    }
}
