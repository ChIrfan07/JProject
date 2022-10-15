using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectJdot
{
    public class Signup : browser

    {
        By signin = By.XPath("//a[text()='Sign In']");

        By createaccount = By.XPath("//span[text()='Create an Account']");

        By fname =   By.Id("firstname");

        By lname =  By.Id("lastname");

        By newsletter = By.Name("is_subscribed");

      //  By aemail = By.Id("alternate_email");

        By dob = By.Id("birth_date");

         By status = By.Id("marital_status");

         By single =  By.XPath("//option[text()='Single']");

         By checkbox =   By.Name("assistance_allowed_checkbox");

         By email =  By.Id("email_address");

          By pass =  By.Name("password");
       
          By repass =  By.Id("password-confirmation");

           By mobile = By.Id("mobilenumber");

          By captacha =  By.Name("captcha[user_create]");


        By account = By.XPath("//span[text()='Create an Account']");

        public void invalidSignup(string firstname, string lastname , string eemail , string password , string repassword , string mobilee , string capt)
        {
          
            Click(signin);
            SwitchFrame();
            SwitchFramedefault();
            Click(createaccount);
            SwitchFrame();
            SwitchFramedefault();
            Write(fname, firstname);
            Write(lname, lastname);
            Click(newsletter);
            scroll(lname);
            PlaybackWait(15000);

            Click(status);
            Click(single);
            Click(checkbox);
            Write(email , eemail);
            Write(pass , password);
            Write(repass , repassword);
            Write(mobile , mobilee);

            PlaybackWait(15000);

            Write(captacha , capt);

            Click(account);

            

        }

        public void validSignup(string firstname, string lastname, string eemail, string password, string repassword, string mobilee, string capt)
        {
          

            Click(signin);
            SwitchFrame();
            SwitchFramedefault();
            Click(createaccount);
            SwitchFrame();
            SwitchFramedefault();
            Write(fname, firstname);
            Write(lname, lastname);
            Click(newsletter);
            scroll(lname);
            PlaybackWait(15000);

          

            Click(status);
            Click(single);
            Click(checkbox);
            Write(email, eemail);
            Write(pass, password);
            Write(repass, repassword);
            Write(mobile, mobilee);

            PlaybackWait(15000);
            

            Write(captacha, capt);

            Click(account);



        }



    }
}

