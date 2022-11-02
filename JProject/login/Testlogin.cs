using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Windows;
using System.Threading;
using AventStack.ExtentReports;

namespace ProjectJdot
{
    [TestClass]
public class Testlogin : ExtentReport
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestInitialize()]

        public void TestInit()

        {

            browser.SeleniumInit("Chrome");

        }


        [TestCleanup()]

        public void TestCleanUp()

        {

            browser.Quitdriver();

        }



        public TestContext instance;
    public TestContext TestContext
    {
        set { instance = value; }
        get { return instance; }

    }
    [ClassInitialize]
     
        public static void ClassInitialize(TestContext testContext)
    {
         //   browser.SeleniumInit("Chrome");
            ExtentReport.LogReport("Extent Report");
    }
    [ClassCleanup]
    public static void ClassCleanUp()
    {
        ExtentReport.extentReports.Flush();
    }



        [TestMethod, TestCategory("Login")]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "logdata.xml", "Login", DataAccessMethod.Sequential)]


        public void JD_TC_2()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("InvalidLogin");
            //ExtentReport.extentReports.CreateTest("InvalidLogin");
            browser.OpenUrl("https://www.junaidjamshed.com");

            
            Country cty = new Country();
            cty.SelectCountry();

            login log1 = new login();

            string user = TestContext.DataRow["email"].ToString();

            string pass = TestContext.DataRow["password"].ToString();

            
            log1.invalidlogin(user, pass);

            log.Info("App is working");
            
        

        }

       
        
        
        
        [TestMethod, TestCategory("Login")]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "logdata.xml", "Login", DataAccessMethod.Sequential)]




        public void JD_TC_1()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("ValidLogin");
            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            login log = new login();

            string user = TestContext.DataRow["emailc"].ToString();

            string pass = TestContext.DataRow["passwordc"].ToString();


            log.validlogin(user, pass);

         //   string expected = "Welcome, Muhammad Irfan!";

          //  string actual = driver.FindElement(By.XPath("(//span[text()='Welcome, Muhammad Irfan!'])[1]")).Text;

          //  Assert.AreEqual(expected, actual);    



        }

      

    }
}
