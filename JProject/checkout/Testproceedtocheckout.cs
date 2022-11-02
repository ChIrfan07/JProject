using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectJdot
{
   
    [TestClass]
    public class Testproceedtocheckout : ExtentReport
    {
        [TestInitialize()]

        public void TestInit()

        {

            browser.SeleniumInit("Chrome");

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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "checkout#CSV", "checkout.csv", DataAccessMethod.Sequential)]

        public void checkout()
        {


            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Proceedtocheckout");
            browser.OpenUrl("https://www.junaidjamshed.com");



            Country cty = new Country();
            cty.SelectCountry();



            addtobag bag = new addtobag();
            bag.addtobagg();

            Thread.Sleep(3000);

            proceedtocheckout check = new proceedtocheckout();

            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string first = TestContext.DataRow["firstname"].ToString();
            string last = TestContext.DataRow["lastname"].ToString();
            string address = TestContext.DataRow["streetaddress"].ToString();
            string province = TestContext.DataRow["province"].ToString();
            string postal = TestContext.DataRow["postal"].ToString();
            string phone = TestContext.DataRow["phonenumber"].ToString();



            check.checkoutt(email, pass, first, last, address, province, postal, phone);

           

        }


    }
}
