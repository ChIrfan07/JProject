using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectJdot
{
    public class Search : browser

    {
        By searchicon  = By.XPath("//i[@class='open-modal-search icon-search3']");

        By text  = By.XPath("//input[@class='input-text vertically-black']");

        By icon = By.XPath("//button[@title='Search']");

        By item = By.XPath("(//li[@class='item product product-item'])[2]");

        public void entertext(string data)
        {
            Click(searchicon);
            Write(text,data);
        }
        
        public void validdatasearch(string data)
        {
            Click(searchicon);
            Write(text, data);
            Click(icon);
            SwitchFrame();
            SwitchFramedefault();
            scrollwindow();
            //hover(item);    

        }

        public void invaliddatasearch(string data)
        {
            Click(searchicon);
            Write(text, data);
            Click(icon);
            SwitchFrame();
            SwitchFramedefault();
        }

    }
}
