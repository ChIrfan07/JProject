using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectJdot
{
    
    [TestClass]
    public class Testaddtobag : ExtentReport
    {
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


        [TestMethod]

        public void addtobag()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("addtobag");

            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            addtobag bag = new addtobag();
            bag.addtobagg();


        }
    }
}
