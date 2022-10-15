using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectJdot

{
    public class contactus : browser
    {

        By contact = By.XPath("//a[text()='Contact Us']");

        By name = By.Id("name");
        By email = By.Id("email");
        By telephone = By.Id("telephone");
        By comment = By.Id("comment");
        By button = By.XPath("//button[@class='action submit primary']"); 
        public void contt(string namee , string emaill , string telephonee, string commentt)
        {
            scroll(contact);
            Click(contact);

            SwitchFrame();
            SwitchFramedefault();

            Write(name, namee);
            Write(email, emaill);
            Write(telephone, telephonee);
            Write(comment, commentt);
            scroll(comment);
            

        }
    }
}
