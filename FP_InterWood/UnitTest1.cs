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
        TS_03_VerifyLogin signInObj = new TS_03_VerifyLogin();
        landingPageClass lpClass = new landingPageClass();
        ElementSelectOnLandingPage eslpObj = new ElementSelectOnLandingPage();

        string url = "https://interwood.pk/";
        string chrome = "chrome";
        string edge = "edge";

        //[TestMethod]
        public void TC_01_BrowserCompatibilityCheck()
        {
            By mainLogo = By.XPath("//*[@id=\"root\"]/main/div[3]/header/div/div/div[1]/div[1]/a/img");

            TS_01_VerifyURLWorkingWithBrowsers testCase = new TS_01_VerifyURLWorkingWithBrowsers();
            testCase.chromeBrowser(chrome, url);
            IWebElement mainPageLogo = testCase.findElement(mainLogo);
            Assert.IsTrue(mainPageLogo != null);
            testCase.LogFile("Home Page has been Loaded Successfully");
            testCase.closeBrowser();

            testCase.edgeBrowser(edge, url);
            Assert.IsTrue(mainPageLogo != null);
            testCase.LogFile("Home Page has been Loaded Successfully");
            testCase.closeBrowser();
            
        }

        //[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signUpData.xml", "SignUpValid", DataAccessMethod.Sequential)]
        public void TC_02_signUpScreen()
        {
            By createdUserName = By.XPath("//button[@class='logged-in']/span/span[contains(text(),'Hi')]");
            TS_02_VerifySignUp signUpObj = new TS_02_VerifySignUp();

            string email = TestContext.DataRow["userEmail"].ToString();
            string password = TestContext.DataRow["userPassword"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string address = TestContext.DataRow["userAddress"].ToString();
            string city = TestContext.DataRow["userCity"].ToString();
            string phone = TestContext.DataRow["userPhone"].ToString();
            signUpObj.LogFile("Email: " + email);
            signUpObj.LogFile("Password: " + password);
            signUpObj.LogFile("First Name: " + firstName);
            signUpObj.LogFile("Last Name: " + lastName);
            signUpObj.LogFile("Address: " + address);
            signUpObj.LogFile("City: " + city);
            signUpObj.LogFile("Phone: " + phone);
            signUpObj.BrowserSelection(chrome);
            signUpObj.landingPage(url);
            signUpObj.TC02_SignUpWithValidCredentials(email, password, firstName, lastName, address, city, phone);
            string str = signUpObj.getText(createdUserName);
            Assert.AreEqual(("Hi, " + firstName),str);
            signUpObj.LogFile(str + " has been successfully Registered.");
            signUpObj.closeBrowser();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signUpData.xml", "SignUpAlreadyRegistered", DataAccessMethod.Sequential)]
        public void TC_03_signUpScreen()
        {
            By message = By.XPath("//span[contains(text(),'A customer with')]");
            TS_02_VerifySignUp signUpObj = new TS_02_VerifySignUp();

            string email = TestContext.DataRow["userEmail"].ToString();
            string password = TestContext.DataRow["userPassword"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string address = TestContext.DataRow["userAddress"].ToString();
            string city = TestContext.DataRow["userCity"].ToString();
            string phone = TestContext.DataRow["userPhone"].ToString();

            signUpObj.BrowserSelection(chrome);
            signUpObj.landingPage(url);
            signUpObj.TC06_SignUpWithAlreadyRegistered(email, password, firstName, lastName, address, city, phone);
            string alertMessage = "A customer with the same email address already exists in an associated website.";
            string actual = signUpObj.getText(message);
            Assert.AreEqual(alertMessage, actual);
            signUpObj.LogFile("" + " cannot Registered as email already exists.");
            signUpObj.closeBrowser();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signUpData.xml", "SignUpInvalid", DataAccessMethod.Sequential)]
        public void TC_04_signUpScreen()
        {
            By invalidEmailFormat = By.XPath("//span[contains(text(),'not a valid email')]");
            TS_02_VerifySignUp signUpObj = new TS_02_VerifySignUp();

            string email = TestContext.DataRow["userEmail"].ToString();
            string password = TestContext.DataRow["userPassword"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string address = TestContext.DataRow["userAddress"].ToString();
            string city = TestContext.DataRow["userCity"].ToString();
            string phone = TestContext.DataRow["userPhone"].ToString();

            signUpObj.BrowserSelection(chrome);
            signUpObj.landingPage(url);
            signUpObj.TC04_SignUpButtonClickable(email, password, firstName, lastName, address, city, phone);
            string str = signUpObj.getText(invalidEmailFormat);
            string alertMessage = "\"" + email +"\" " + "is not a valid email address.";
            Assert.AreEqual(alertMessage, str);
            signUpObj.LogFile(str + " Cannot be registered with Invalid Email format.");
            signUpObj.closeBrowser();
        }
        //[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signUpData.xml", "SignUpBlankCredentials", DataAccessMethod.Sequential)]
        public void TC_05_signUpScreen()
        {
            By errorMessage = By.XPath("//*/p[contains(text(),'Is requi')]");
            TS_02_VerifySignUp signUpObj = new TS_02_VerifySignUp();

            string email = TestContext.DataRow["userEmail"].ToString();
            string password = TestContext.DataRow["userPassword"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string address = TestContext.DataRow["userAddress"].ToString();
            string city = TestContext.DataRow["userCity"].ToString();
            string phone = TestContext.DataRow["userPhone"].ToString();

            signUpObj.BrowserSelection(chrome);
            signUpObj.landingPage(url);
            signUpObj.TC05_SignUpWithoutAcceptingTerms(email, password, firstName, lastName, address, city, phone);
            string message = "Is required.";
            string collectedMessage = signUpObj.getText(errorMessage);
            Assert.AreEqual(message, collectedMessage);
            signUpObj.LogFile(collectedMessage + " because user cannot be registered with blank mandatory fields.");
            signUpObj.closeBrowser();
        }
       // [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signUpData.xml", "SignUpValid", DataAccessMethod.Sequential)]
        public void TC_06_signUpScreen()
        {
            By createdUserName = By.XPath("//button[@class='logged-in']/span/span[contains(text(),'Hi')]");
            TS_02_VerifySignUp signUpObj = new TS_02_VerifySignUp();

            string email = TestContext.DataRow["userEmail"].ToString();
            string password = TestContext.DataRow["userPassword"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string address = TestContext.DataRow["userAddress"].ToString();
            string city = TestContext.DataRow["userCity"].ToString();
            string phone = TestContext.DataRow["userPhone"].ToString();

            signUpObj.BrowserSelection(chrome);
            signUpObj.landingPage(url);
            signUpObj.TC05_SignUpWithoutAcceptingTerms(email, password, firstName, lastName, address, city, phone);
            signUpObj.closeBrowser();
        }

        //[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signInData.xml", "LoginValid", DataAccessMethod.Sequential)]
        public void TC_06_SignInScreen()
        {
            TS_03_VerifyLogin signInObj = new TS_03_VerifyLogin();

            string email = TestContext.DataRow["userEmail"].ToString();
            string pass = TestContext.DataRow["userPassword"].ToString();

            signInObj.BrowserSelection(chrome);
            signInObj.landingPage(url);
            signInObj.SignInFunctionality(email, pass);
            
            signInObj.closeBrowser();
        }
        //[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signInData.xml", "LoginInvalid", DataAccessMethod.Sequential)]
        public void TC_07_SignInScreen()
        {
            TS_03_VerifyLogin signInObj = new TS_03_VerifyLogin();

            string email = TestContext.DataRow["userEmail"].ToString();
            string pass = TestContext.DataRow["userPassword"].ToString();

            signInObj.BrowserSelection(chrome);
            signInObj.landingPage(url);
            signInObj.SignInFunctionality(email, pass);
            signInObj.closeBrowser();
        }
        //[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signInData.xml", "LoginWithUnregistered", DataAccessMethod.Sequential)]
        public void TC_08_SignInScreen()
        {
            TS_03_VerifyLogin signInObj = new TS_03_VerifyLogin();

            string email = TestContext.DataRow["userEmail"].ToString();
            string pass = TestContext.DataRow["userPassword"].ToString();

            signInObj.BrowserSelection(chrome);
            signInObj.landingPage(url);
            signInObj.SignInFunctionality(email, pass);
            signInObj.closeBrowser();
        }
        //[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signInData.xml", "LoginWithEmptyEmailPass", DataAccessMethod.Sequential)]
        public void TC_09_SignInScreen()
        {
            TS_03_VerifyLogin signInObj = new TS_03_VerifyLogin();

            string email = TestContext.DataRow["userEmail"].ToString();
            string pass = TestContext.DataRow["userPassword"].ToString();

            signInObj.BrowserSelection(chrome);
            signInObj.landingPage(url);
            signInObj.SignInFunctionality(email, pass);
            signInObj.closeBrowser();
        }
        //[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signInData.xml", "LoginWithEmptyEmail", DataAccessMethod.Sequential)]
        public void TC_10_SignInScreen()
        {
            TS_03_VerifyLogin signInObj = new TS_03_VerifyLogin();

            string email = TestContext.DataRow["userEmail"].ToString();
            string pass = TestContext.DataRow["userPassword"].ToString();

            signInObj.BrowserSelection(chrome);
            signInObj.landingPage(url);
            signInObj.SignInFunctionality(email, pass);
            signInObj.closeBrowser();
        }
        //[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "signInData.xml", "LoginWithEmptyPass", DataAccessMethod.Sequential)]
        public void TC_11_SignInScreen()
        {
            TS_03_VerifyLogin signInObj = new TS_03_VerifyLogin();

            string email = TestContext.DataRow["userEmail"].ToString();
            string pass = TestContext.DataRow["userPassword"].ToString();

            signInObj.BrowserSelection(chrome);
            signInObj.landingPage(url);
            signInObj.SignInFunctionality(email, pass);
            signInObj.closeBrowser();
        }
    }
}
