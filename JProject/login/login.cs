using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace ProjectJdot
{
    public class login:browser 
    {
        

       By signin = By.XPath("//a[text()='Sign In']");

        By enterusername = By.Name("login[username]");

        By enterpassword = By.Name("login[password]");

        By submit = By.Id("send2");

    

        public void invalidlogin(string email, string password)
        {
          Click(signin);

            ImplicitWait(60);

            SwitchFrame();
            SwitchFramedefault();

            ImplicitWait(30);

            Write(enterusername, email);
            Write(enterpassword, password);
            
          
            Click(submit);
            SwitchFrame();
            SwitchFramedefault();
        }

        public void validlogin(string email, string password)
        {
            
            Click(signin);

            ImplicitWait(60);

            SwitchFrame();
            SwitchFramedefault();

            Write(enterusername, email);
            Write(enterpassword, password);

            Click(submit);
            SwitchFrame();
            SwitchFramedefault();

        }
        




    }
}










//  IWebDriver driver1;

//public login(IWebDriver driver)
//{
//    driver1 = driver;
//}


//public void click()
//{
//    driver1.FindElement(country).Click();
//    driver1.FindElement(country1).Click();
//    driver1.FindElement(enter).Click();
//    driver1.FindElement(signin).Click();

//}

//public void signIn(string email, string password)
//{

//    driver1.FindElement(enterusername).SendKeys(email);
//    driver1.FindElement(enterpassword).SendKeys(password);
//    driver1.FindElement(submit).Click();

//}










