using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

 namespace ProjectJdot

{
  
    [TestClass]
    public class Testfilter : browser
    {
        [TestInitialize()]

        public void TestInit()

        {

            browser.SeleniumInit("Chrome");

        }

        [TestMethod]

        public void shoppingoption()
        {

            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            filter options = new filter();
            options.shoppingoptions();


        }
    }
}
