using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectJdot
{
    
    [TestClass]

    public class Testtrackinginfo : browser

    {

        private static readonly log4net.ILog log =log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 

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

        [TestMethod]

        public void trackinfo()
        {
            
            ExtentReport.extentReports.CreateTest("tracking info");
            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            trackinginfo info = new trackinginfo();
            info.tracking("XYZ123F");

            log.Info("trackinfo app is working");

        }
    }
}
