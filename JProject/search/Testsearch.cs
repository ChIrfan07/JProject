using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectJdot
{
    
    [TestClass]
    public class Testsearch : ExtentReport
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

        public void entertextSearch()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("entertextSearch");
            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            Search search = new Search();
            search.entertext("KAMEEZ SHALWAR");


        }

        [TestMethod]

        public void entervalidSearch()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("entervalidSearch");
            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            Search search = new Search();
            search.validdatasearch("KAMEEZ SHALWAR");


        }

        [TestMethod]

        public void inentervalidSearch()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("inentervalidSearch");
            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            Search search = new Search();
            search.invaliddatasearch("Bike");


        }

    }
}
