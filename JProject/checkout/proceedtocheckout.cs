using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ProjectJdot
{
    public class proceedtocheckout : browser
    {
        By checkouttt = By.Id("top-cart-btn-checkout");
       
        By eemail = By.Id("customer-email");
        By login = By.XPath("//button[@class='action login primary']");
        By password = By.Id("customer-password"); 
        By fname = By.Name("firstname");
        By lname = By.Name("lastname");
        By street = By.Name("street[0]");
   
        By country = By.Name("country_id");
        // By countrry = By.XPath("//option[text()='Pakistan']");
        By state = By.Name("region");
        
        By city = By.XPath("//select[@class='select']");
        By city1 = By.XPath("//option[text()='LAHORE']");
        By postall = By.Name("postcode");
        By phonenumber = By.Name("telephone");
        By next = By.XPath("//button[@class='button action continue primary']");
        By cash = By.Id("cashondelivery");
        By check = By.Id("billing-address-same-as-shipping-cashondelivery");
        By  button = By.XPath("//button[@class='action primary checkout']"); 
        public void checkoutt(string email,string pass, string first, string last, string address, string province,string postal, string phone)
        {
            Click(checkouttt);

            

            SwitchFrame();
            SwitchFramedefault();

       

            Write(eemail, email);

            ImplicitWait(10);

            Click(login);



            ImplicitWait(10);

            scrollwindow();

            Write(password,pass);
            Write(fname, first);
            Write(lname, last);
            Write(street, address);
            Click(country);
            drop(country,"Pakistan");
           //Click(countrry);     
            Write(state, province);
            Click(city);
            Click(city1);
            Write(postall, postal);
            Write(phonenumber, phone);
            Click(next);
             scrollwindow();
             Click(cash);
             Click(check);

        }
    }
}
