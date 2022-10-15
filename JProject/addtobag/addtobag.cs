using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace ProjectJdot
{
    public class addtobag : browser
    {
        By men = By.XPath("//span[text()='Men']");

        By pajama = By.XPath("//span[text()='Kurta Pajama']");

        By item = By.XPath("(//li[@class='item product product-item'])[2]");

        By price = By.XPath("//span[@class='price']");

        By button = By.XPath("//div[text()='M']");


        By addbag = By.XPath("//span[text()='Add to Bag']");


        public void addtobagg()
        {
           
            hover(men);
            Click(pajama);
            SwitchFrame();
            SwitchFramedefault();
            scrollwindow();
            Click(item);
            SwitchFrame();
            SwitchFramedefault();
            Click(button);
            scroll(price);
            Click(addbag);


        }


    }
}



