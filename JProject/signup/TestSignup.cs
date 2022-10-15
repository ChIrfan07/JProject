using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectJdot
{
   
    [TestClass]
    public class TestSignup : browser
    {



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
            ExtentReport.LogReport("Extent_Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            ExtentReport.extentReports.Flush();
        }


        [TestInitialize]

        public void TestInit()

        {

            browser.SeleniumInit("Chrome");

        }


        [TestCleanup]

        public void TestCleanUp()

        {

            browser.Closedriver();

        }



       


        [TestMethod]

        public void invalidsignup()
        {
            ExtentReport.extentReports.CreateTest("InvalidSignup");
            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            Signup signup = new Signup();

            signup.invalidSignup("Muhammad", "Irfan", "chaudharyirfangmailcom", "M.irfan25", "M.irfan25", "03211483646", "");



        }

        [TestMethod]

        public void validsignup()
        {
            ExtentReport.extentReports.CreateTest("Signup");
            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            Signup signup = new Signup();



            signup.validSignup("Muhammad", "Irfan", "crispyice12366@gmail.com", "M.irfan25", "M.irfan25", "03211483646", " ");

        }
    }
}
