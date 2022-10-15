using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectJdot
{
    public class trackinginfo : browser

    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        By track = By.XPath("//a[text()='Tracking Info']");
        By text = By.XPath("//input[@class='input-text required']");
        By button = By.XPath("//button[@class='action primary']");


        public void tracking(string id)
        {
            Click(track);
            SwitchFrame();
            SwitchFramedefault();

            Click(text);
            Write(text, id);
            log.Info("Invalid id");
            Click(button);
            
            SwitchFrame();
            SwitchFramedefault();
            PlaybackWait(1000);
        }
    }
}
