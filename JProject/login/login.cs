using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace ProjectJdot
{
    public class login:browser 
    {
        

       By signin = By.XPath("//a[text()='Sign In']");

        By enterusername = By.Name("login[username]");

        By enterpassword = By.Name("login[password]");

        By submit = By.Id("send2");

        By cc = By.XPath("(//span[@class='logged-in'])[1]");

        By actuall = By.XPath("//div[@data-bind='html: $parent.prepareMessageForHtml(message.text)']");

    

        public void invalidlogin(string email, string password)
        {
          Click(signin);

            ImplicitWait(10);

            SwitchFrame();
            SwitchFramedefault();

            ImplicitWait(10);

            Write(enterusername, email);
            Write(enterpassword, password);
            Click(submit);
            SwitchFrame();
            SwitchFramedefault();
            Assertion("The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later.", actuall);
        }

        public void validlogin(string email, string password)
        {
            
            Click(signin);

            ImplicitWait(10);

            SwitchFrame();
            SwitchFramedefault();

            ImplicitWait(10);

            Write(enterusername, email);
            Write(enterpassword, password);

            Click(submit);
            SwitchFrame();
            SwitchFramedefault();


          //  GetElementText(cc);



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










