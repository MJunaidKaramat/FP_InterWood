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
        private TestContext testContext;
        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }

        GeneralMethodsClass obj = new GeneralMethodsClass();
        SignUPClass signUpObj = new SignUPClass();
        landingPageClass lpObj = new landingPageClass();
        SignInClass signInObj = new SignInClass();
        landingPageClass lpClass = new landingPageClass();
        ElementSelectOnLandingPage eslpObj = new ElementSelectOnLandingPage();

        string url = "https://interwood.pk/";
        string chrome = "chrome";
        string edge = "edge";

        [TestMethod]
        public void BrowserCompatibilityCheck()
        {
            TS_01_VerifyURLWorkingWithBrowsers testCase = new TS_01_VerifyURLWorkingWithBrowsers();
            testCase.chromeBrowser(chrome, url);
            testCase.closeBrowser();
            testCase.edgeBrowser(edge, url);
            testCase.closeBrowser();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signUpData.xml", "SignUpValid", DataAccessMethod.Sequential)]
        public void signUpScreen1()
        {
            TS_02_VerifySignUp signUpObj = new TS_02_VerifySignUp();

            string email = TestContext.DataRow["userEmail"].ToString();
            string password = TestContext.DataRow["userPassword"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string address = TestContext.DataRow["userAddress"].ToString();
            string city = TestContext.DataRow["userCity"].ToString();
            string phone = TestContext.DataRow["userPhone"].ToString();
            
            signUpObj.BrowserSelection(edge);
            signUpObj.landingPage(url);
            signUpObj.TC03_SignUpWithValidCredentials(email, password, firstName, lastName, address, city, phone);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signUpData.xml", "SignUpInvalid", DataAccessMethod.Sequential)]
        public void signUpScreen2()
        {
            TS_02_VerifySignUp signUpObj = new TS_02_VerifySignUp();

            string email = TestContext.DataRow["userEmail"].ToString();
            string password = TestContext.DataRow["userPassword"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string address = TestContext.DataRow["userAddress"].ToString();
            string city = TestContext.DataRow["userCity"].ToString();
            string phone = TestContext.DataRow["userPhone"].ToString();

            signUpObj.BrowserSelection(edge);
            signUpObj.landingPage(url);
            signUpObj.TC04_SignUpWithInvalidCredentials(email, password, firstName, lastName, address, city, phone);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signUpData.xml", "SignUpClickable", DataAccessMethod.Sequential)]
        public void signUpScreen3()
        {
            TS_02_VerifySignUp signUpObj = new TS_02_VerifySignUp();

            string email = TestContext.DataRow["userEmail"].ToString();
            string password = TestContext.DataRow["userPassword"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string address = TestContext.DataRow["userAddress"].ToString();
            string city = TestContext.DataRow["userCity"].ToString();
            string phone = TestContext.DataRow["userPhone"].ToString();

            signUpObj.BrowserSelection(edge);
            signUpObj.landingPage(url);
            signUpObj.TC05_SignUpButtonClickable(email, password, firstName, lastName, address, city, phone);
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
