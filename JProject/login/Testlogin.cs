using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Windows;
using System.Threading;

namespace ProjectJdot
{ 
 [TestClass]
public class Testlogin : browser
{

        [TestInitialize()]

        public void TestInit()

        {

            browser.SeleniumInit("Chrome");

        }


        [TestCleanup()]

        public void TestCleanUp()

        {

            browser.Closedriver();

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

    //[TestClass]
    //public class Testlogin : browser
    //{


    //    [TestInitialize()]

   

        //public TestContext instance;
        //public TestContext TestContext
        //{
        //    set { instance = value; }
        //    get { return instance; }
        //}

        [TestMethod, TestCategory("Login")]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "logdata.xml", "Login", DataAccessMethod.Sequential)]


        public void JD_TC_2()
        {
            ExtentReport.extentReports.CreateTest("InvalidLogin");
            OpenUrl("https://www.junaidjamshed.com");

            
            Country cty = new Country();
            cty.SelectCountry();

            login log = new login();

            string user = TestContext.DataRow["email"].ToString();

            string pass = TestContext.DataRow["password"].ToString();


            log.invalidlogin(user, pass);



        }

       
        
        
        
        [TestMethod, TestCategory("Login")]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "logdata.xml", "Login", DataAccessMethod.Sequential)]




        public void JD_TC_1()
        {
            ExtentReport.extentReports.CreateTest("validLogin");
            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            login log = new login();

            string user = TestContext.DataRow["emailc"].ToString();

            string pass = TestContext.DataRow["passwordc"].ToString();


            log.validlogin(user, pass);



        }

      

    }
}
