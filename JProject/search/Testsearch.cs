using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectJdot
{
    
    [TestClass]
    public class Testsearch : browser
    {
        [TestInitialize()]

        public void TestInit()

        {

            browser.SeleniumInit("Chrome");

        }

        [TestMethod]

        public void entertextSearch()
        {

            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            Search search = new Search();
            search.entertext("KAMEEZ SHALWAR");


        }

        [TestMethod]

        public void entervalidSearch()
        {

            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            Search search = new Search();
            search.validdatasearch("KAMEEZ SHALWAR");


        }

        [TestMethod]

        public void inentervalidSearch()
        {

            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            Search search = new Search();
            search.invaliddatasearch("Bike");


        }

    }
}
