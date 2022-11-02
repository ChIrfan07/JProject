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
    public class TestCountry : ExtentReport
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

        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {

        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {

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
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Country");
            browser.OpenUrl("https://www.junaidjamshed.com");
             Country cty = new Country();
             cty.SelectCountry();

            }
        }
    }

