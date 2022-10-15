using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

 namespace ProjectJdot

{
   
    [TestClass]
    public class Testdisplaymodes : browser
    {
        [TestInitialize()]

        public void TestInit()

        {

            browser.SeleniumInit("Chrome");

        }

        [TestMethod]

        public void viewas()
        {

            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            displaymodes grid1 = new displaymodes();
            grid1.view();


        }

    }
}
