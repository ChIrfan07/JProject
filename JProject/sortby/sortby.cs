﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectJdot
{
    public class sortby : browser
    {
        By men = By.XPath("//span[text()='Men']");
        By kameez = By.Id("ui-id-72");
        By sortt = By.XPath("//div[contains(@class,'toolbar-sorter sorter')]");
        By sorttt = By.XPath("//option[contains(text(),'Newest Arrivals')]");

       


        public void sort()
        {
            hover(men);
            Click(kameez);
            SwitchFrame();
            SwitchFramedefault();
         
            Click(sortt);
            //IWebElement ele= driver.FindElement(By.ClassName("sorter-options"));
            //ele.Click();
            //ele.SendKeys(Keys.ArrowDown + Keys.ArrowDown);
            ImplicitWait(40);
             Click(sorttt);
            scrollwindow();
            SwitchFrame();
            SwitchFramedefault();
        }

    }
}
