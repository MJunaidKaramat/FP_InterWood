using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace FP_InterWood
{
    [TestClass]
    public class UnitTest1
    {
        GeneralMethodsClass obj = new GeneralMethodsClass("ChRomE");
        SignUPClass signUpObj = new SignUPClass();
        landingPageClass lpObj = new landingPageClass();
        SignInClass signInObj = new SignInClass();
        string url = "https://interwood.pk/";
        
        [TestMethod]
        public void signUpScreen()
        {
            signUpObj.landingPage(url);
            lpObj.signinSignUpButton();
            System.Threading.Thread.Sleep(2000);
            signUpObj.signUp();
        }
        [TestMethod]
        public void signInScreen()
        {
            signInObj.landingPage(url);
            lpObj.signinSignUpButton();
            signInObj.signIn();
        }
    }
}
