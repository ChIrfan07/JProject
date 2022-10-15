using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Windows;
using System.Threading;

namespace ProjectJdot
{
  
    [TestClass]
    public class TestCountry:browser
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


        [TestMethod]
            public void country()
            {
            ExtentReport.extentReports.CreateTest("Country");
            browser.OpenUrl("https://www.junaidjamshed.com");
                Country cty = new Country();
                cty.SelectCountry();

            }
        }
    }

