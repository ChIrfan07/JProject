using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

 namespace ProjectJdot

{
   
    [TestClass]
    public class Testdisplaymodes : ExtentReport
    {
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


        [TestMethod]

        public void viewas()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("viewas");

            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            displaymodes grid1 = new displaymodes();
            grid1.view();


        }

    }
}
