using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectJdot
{
    public class filter : browser
    {
        By men = By.XPath("//span[text()='Men']");

        By pajama = By.XPath("//span[text()='Kurta Pajama']");

        By weart = By.XPath("//div[text()='Wear Type']");

        By semi = By.XPath("//a[text()='Semi-Formal']"); 

        public void shoppingoptions()
        {
            hover(men);
            Click(pajama);
            SwitchFrame();
            SwitchFramedefault();
            scrollwindow();
            Click(weart);
            Click(semi);
            SwitchFrame();
            SwitchFramedefault();
            scrollwindow();
        }
    }
}
