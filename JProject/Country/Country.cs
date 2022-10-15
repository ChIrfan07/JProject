using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectJdot
{
    public class Country : browser
    {
        //By frme = By.XPath("//iframe[@id='webpush-onsite']");
        //By noti = By.XPath("//button[@id='deny']");

        By country = By.Id("landing-currency");

        By country1 = By.XPath("//option[@value='PKR']");
        
        By enter = By.XPath("//button[@class='form-control jj-enter-btn']");
        //   By popup = By.XPath("//*[@id='allow' and @class='button']");

        public void SelectCountry()
        {

            SwitchFrame();
            SwitchFramedefault();
            Click(country);
            ImplicitWait(30);

            Click(country1);
            ImplicitWait(30);
            Click(enter);
            SwitchFrame();
            SwitchFramedefault();
        }
    }
}
