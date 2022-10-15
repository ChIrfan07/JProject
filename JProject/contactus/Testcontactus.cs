using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectJdot
{
    
    [TestClass]
    public class Testcontactus :  browser
    {
        [TestInitialize()]

        public void TestInit()

        {

            browser.SeleniumInit("Chrome");

        }

        [TestMethod]

        public void contact()
        {

            browser.OpenUrl("https://www.junaidjamshed.com");
            Country cty = new Country();
            cty.SelectCountry();

            contactus cont = new contactus();
            cont.contt("Irfan", "crispyice12366@yahoo.com", "03211483646", "Your products are good");

        }


    }
}

