using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace FP_InterWood
{
    [TestClass]
    public class MainadsfgsClass
    {
        GeneralMethodsClass obj = new GeneralMethodsClass("chrome");
        SignUPClass signUpObj = new SignUPClass();
        string url = "https://interwood.pk/";
        
        [TestMethod]
        public void signUpScreen()
        {
           
            signUpObj.landingPage(url);
            System.Threading.Thread.Sleep(2000);
             signUpObj.signUp();
        }
    }
}
