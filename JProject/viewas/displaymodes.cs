using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectJdot
{
    public class displaymodes : browser
    {
        By men = By.XPath("//span[text()='Men']");
        By caps = By.XPath("//span[text()='Caps']");
        By Clicklist = By.Id("mode-list");
        By gridlist = By.Id("mode-grid");

       // By scrollimage = By.XPath("//div[@class='category-image']");

        //By viewas = By.ClassName("modes");

        //   By list = By.XPath("//a[title()='List']");

        //By grid = By.XPath(("(//strong[@title='Grid'])[1]"));


        //By list = By.XPath("(//a[@id='mode-list'])[1]");

        //By grid = By.XPath("(//a[@id='mode-grid'])[1]");

        public void view()
        {
            hover(men);
            Click(caps);
            SwitchFrame();
            SwitchFramedefault();
          //  scroll(scrollimage);
            ImplicitWait(5);

            Click(Clicklist);
          //  scroll(scrollimage);
            SwitchFrame();
            SwitchFramedefault();
            ImplicitWait(5);

            Click(gridlist);
          //  scroll(scrollimage);
            SwitchFrame();
            SwitchFramedefault();


        }

    }
}
