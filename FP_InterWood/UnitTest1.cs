using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace FP_InterWood
{
    [TestClass]
    public class UnitTest1
    {
        GeneralMethodsClass obj = new GeneralMethodsClass("ChRomE");
        SignUPClass signUpObj = new SignUPClass();
        landingPageClass lpObj = new landingPageClass();
        SignInClass signInObj = new SignInClass();
        landingPageClass lpClass = new landingPageClass();
        ElementSelectOnLandingPage eslpObj = new ElementSelectOnLandingPage();

        string url = "https://interwood.pk/";
        
        [TestMethod]
        public void signUpScreen()
        {
            signUpObj.landingPage(url);
            lpObj.signinSignUpButton();
            Thread.Sleep(2000);
            signUpObj.signUp();
        }
        [TestMethod]
        public void signInScreen()
        {
            signInObj.landingPage(url);
            lpObj.signinSignUpButton();
            System.Threading.Thread.Sleep(3000);
            signInObj.signIn();
        }
        [TestMethod]
        public void LandingPage()
        {
            lpClass.landingPage(url);
            lpClass.ScrollHomePage();
            Thread.Sleep(4000);
            lpClass.cartStatus();
            lpClass.cartStatus();
            lpClass.navBarScrolling();
        }
        [TestMethod]
        public void selectElementPage()
        {
            eslpObj.landingPage(url);
            eslpObj.selectObject();
        }
    }
}
