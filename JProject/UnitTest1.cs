//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System.Windows;
//using System.Threading;

//namespace ProjectJdot
//{
//    [TestClass]
//    public class UnitTest1 : browser 
//    {

//        [TestInitialize()]

//        public void TestInit()

//        {

//            browser.SeleniumInit("Chrome");

//        }

//        //[TestCleanup()]

//        //public void TestCleanUp()

//        //{

//        //    browser.Closedriver();

//        //}

//        //[TestMethod]
//        //public void country()
//        //{
//        //    browser.OpenUrl("https://www.junaidjamshed.com");
//        //    Country cty = new Country();
//        //    cty.SelectCountry();

//        //}

//        public TestContext instance;
//        public TestContext TestContext
//        {
//            set { instance = value; }
//            get { return instance; }
//        }



//        [TestMethod, TestCategory("Login")]

//        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "logdata.xml", "Login", DataAccessMethod.Sequential)]


//        public void invalidLogin()
//        {
//           OpenUrl("https://www.junaidjamshed.com");
//            Thread.Sleep(2000);

//          //  browser.message();

//            Country cty = new Country();
//            cty.SelectCountry();

//            login log = new login();

//            string user = TestContext.DataRow["email"].ToString();

//            string pass = TestContext.DataRow["password"].ToString();

            
//            log.invalidlogin(user, pass);

          

//           }



//        [TestMethod, TestCategory("Login")]

//        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "logdata.xml", "Login", DataAccessMethod.Sequential)]




//        public void validLogin()
//        {
//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            login log = new login();

//            string user = TestContext.DataRow["emailc"].ToString();

//            string pass = TestContext.DataRow["passwordc"].ToString();


//            log.validlogin(user, pass);

            

//        }

//        [TestMethod]

//        public void invalidsignup()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            Signup signup = new Signup();

//            signup.invalidSignup("Muhammad", "Irfan", "chaudharyirfangmailcom", "M.irfan25", "M.irfan25", "03211483646","");



//        }

//        [TestMethod]

//        public void validsignup()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            Signup signup = new Signup();



//            signup.validSignup("Muhammad", "Irfan", "crispyice12366@gmail.com", "M.irfan25", "M.irfan25", "03211483646", " ");

//        }

//        [TestMethod]

//        public void entertextSearch()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            Search search = new Search();
//            search.entertext("KAMEEZ SHALWAR");


//        }

//        [TestMethod]

//        public void entervalidSearch()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            Search search = new Search();
//            search.validdatasearch("KAMEEZ SHALWAR");


//        }

//        [TestMethod]

//        public void inentervalidSearch()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            Search search = new Search();
//            search.invaliddatasearch("Bike");


//        }

//        [TestMethod]

//        public void addtobag()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            addtobag bag = new addtobag();
//            bag.addtobagg();


//        }

//        [TestMethod]

//        public void shoppingoption()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            filter options = new filter();
//            options.shoppingoptions();


//        }


//        [TestMethod]

//        public void viewas()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            displaymodes grid1 = new displaymodes();
//            grid1.view();


//        }

//        [TestMethod]

//        public void sortb()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            sortby sortt = new sortby();

//            sortt.sort();


//        }

//        [TestMethod]

//        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "logdata.xml", "Login", DataAccessMethod.Sequential)]

//        public void flow()
//        {
//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            login log = new login();

//            string user = TestContext.DataRow["emailc"].ToString();

//            string pass = TestContext.DataRow["passwordc"].ToString();


//            log.validlogin(user, pass);


//            Search search = new Search();
//            search.validdatasearch("KAMEEZ SHALWAR");

//            addtobag bag = new addtobag();
//            bag.addtobagg();

//        }

//        [TestMethod]
//        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "checkout#CSV", "checkout.csv", DataAccessMethod.Sequential)]

//        public void checkout()
//        {
//            browser.OpenUrl("https://www.junaidjamshed.com");

          

//            Country cty = new Country();
//            cty.SelectCountry();

            

//            addtobag bag = new addtobag();
//            bag.addtobagg();

//            Thread.Sleep(3000);

//            proceedtocheckout check = new proceedtocheckout();

//            string email = TestContext.DataRow["email"].ToString();
//            string pass = TestContext.DataRow["password"].ToString();
//            string first = TestContext.DataRow["firstname"].ToString();
//            string last = TestContext.DataRow["lastname"].ToString();
//            string address = TestContext.DataRow["streetaddress"].ToString();
//            string province = TestContext.DataRow["province"].ToString();
//            string postal = TestContext.DataRow["postal"].ToString();
//            string phone = TestContext.DataRow["phonenumber"].ToString();



//            check.checkoutt(email,pass, first, last, address, province, postal, phone);

//            Thread.Sleep(10000);

//        }

//        [TestMethod]

//        public void contact()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//            contactus cont = new contactus();
//            cont.contt("Irfan","crispyice12366@yahoo.com","03211483646","Your products are good");

//        }

//        [TestMethod]

//        public void trackinfo()
//        {

//            browser.OpenUrl("https://www.junaidjamshed.com");
//            Country cty = new Country();
//            cty.SelectCountry();

//           trackinginfo info = new trackinginfo();
//            info.tracking("XYZ123F");

//        }

//    }
//}






////  browser.SeleniumInit("Chrome");


//// IWebDriver driver = new ChromeDriver();
//// driver.Manage().Window.Maximize();
//// driver.Url = "https://www.junaidjamshed.com/";

////  login log1 = new login(driver);
//////  log1.click();
////  log1.signIn("crispyice12366@gmail.com", "M.irfan25");












////[TestMethod]
////public void SignUpPage()
////{
////    IWebDriver driver = new ChromeDriver();
////    driver.Url = "https://www.junaidjamshed.com/select-country";
////    driver.Manage().Window.Maximize();

////    //Thread.Sleep(20000);

////  //  driver.FindElement(By.XPath("//div[contains(@class,'button-group-custom clearfix']"));

//// //   IWebElement disable = driver.FindElement(By.Id("deny"));
//// //   disable.Click();

////    IWebElement land = driver.FindElement(By.Id("landing-currency"));
////    land.Click();

////    Thread.Sleep(2000);


////    IWebElement country = driver.FindElement(By.XPath("//option[@value='PKR']"));
////    country.Click();



////    IWebElement enter = driver.FindElement(By.XPath("//button[@class='form-control jj-enter-btn']"));
////    enter.Click();
////    //IWebElement signIn = driver.FindElement(By.XPath("//li[@class='link authorization-link']"));
////    IWebElement signIn = driver.FindElement(By.XPath("//a[text()='Sign In']"));
////    signIn.Click();
////    IWebElement createAnAccount = driver.FindElement(By.XPath("//span[text()='Create an Account']"));
////    createAnAccount.Click();
////    IWebElement firstName = driver.FindElement(By.Id("firstname"));
////    firstName.Click();
////    firstName.SendKeys("Muhammad");
////    IWebElement lastName = driver.FindElement(By.Id("lastname"));
////    lastName.Click();
////    lastName.SendKeys("Irfan");
////    IWebElement newsLetter = driver.FindElement(By.Name("is_subscribed"));
////    newsLetter.Click();
////    IWebElement aEmail = driver.FindElement(By.Id("alternate_email"));
////    aEmail.Click();
////    aEmail.SendKeys("chaudhary.irfan038@gmail.com");
////    IWebElement dob = driver.FindElement(By.Id("birth_date"));
////    dob.Click();
////    dob.Clear();
////    dob.SendKeys("5/26/97" + Keys.Enter);



////    IWebElement maritalStatus = driver.FindElement(By.Id("marital_status"));
////    maritalStatus.Click();

////    IWebElement maritalStatus1 = driver.FindElement(By.XPath("//option[text()='Single']"));
////    maritalStatus1.Click();

////    IWebElement allowAssistance = driver.FindElement(By.Name("assistance_allowed_checkbox"));
////    allowAssistance.Click();

////    IWebElement email = driver.FindElement(By.Id("email_address"));
////    email.Click();
////    email.SendKeys("crispyice12366@gmail.com");
////    IWebElement password = driver.FindElement(By.Name("password"));
////    password.Click();
////    password.SendKeys("M.irfan25");
////    IWebElement confirmPassword = driver.FindElement(By.Id("password-confirmation"));
////    confirmPassword.Click();
////    confirmPassword.SendKeys("M.irfan25");
////    IWebElement mobileNum = driver.FindElement(By.Id("mobilenumber"));
////    mobileNum.Click();
////    mobileNum.SendKeys("0321483646");
////    IWebElement reCap = driver.FindElement(By.Name("captcha[user_create]"));
////    reCap.Click();
////    Thread.Sleep(10000);
////    IWebElement createAnAcc = driver.FindElement(By.XPath("//span[text()='Create an Account']"));
////    createAnAcc.Click();
////}

////[TestMethod]
////public void SignInPage()
////  {
////    IWebDriver driver = new ChromeDriver();
////    driver.Url = "https://www.junaidjamshed.com/";
////    driver.Manage().Window.Maximize();
////    IWebElement country = driver.FindElement(By.XPath("//option[@value='PKR']"));
////    country.Click();
////    IWebElement enter = driver.FindElement(By.XPath("//button[@class='form-control jj-enter-btn']"));
////    enter.Click();
////    IWebElement signInPage = driver.FindElement(By.XPath("//a[text()='Sign In']"));
////    signInPage.Click();
////    IWebElement logIn = driver.FindElement(By.Name("login[username]"));
////    logIn.Click();
////    logIn.SendKeys("crispyice12366@gmail.com");
////    IWebElement enterPassword = driver.FindElement(By.Name("login[password]"));
////    enterPassword.Click();
////    enterPassword.SendKeys("M.irfan25");
////    IWebElement signIn = driver.FindElement(By.XPath("//button[@class='action login primary']"));
////    signIn.Click();

//// }


////[TestMethod]
////public void search()

////{


////    IWebDriver driver = new ChromeDriver();
////    driver.Url = "https://www.junaidjamshed.com/select-country";
////    driver.Manage().Window.Maximize();
////    //Thread.Sleep(20000);
////    //  driver.FindElement(By.XPath("//div[contains(@class,'button-group-custom clearfix']"))
////    //   IWebElement disable = driver.FindElement(By.Id("deny"));
////    //   disable.Click();
////    IWebElement land = driver.FindElement(By.Id("landing-currency"));
////    land.Click();
////    Thread.Sleep(2000);
////    IWebElement country = driver.FindElement(By.XPath("//option[@value='PKR']"));
////    country.Click();
////    IWebElement enter = driver.FindElement(By.XPath("//button[@class='form-control jj-enter-btn']"));
////    enter.Click();

////    IWebElement ser = driver.FindElement(By.XPath("//i[@class='open-modal-search icon-search3']"));
////    ser.Click();

////    IWebElement textt = driver.FindElement(By.XPath("//input[@class='input-text vertically-black']"));
////    textt.SendKeys("KAMEEZ SHALWAR");

////    IWebElement SS1 = driver.FindElement(By.XPath("//button[@title='Search']"));
////    SS1.Click();

////    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
////    Thread.Sleep(2000);
////    js.ExecuteScript("window.scrollBy(0,500);");

////   }



////[TestMethod]

////public void addtocart()
////{

////}





////    }
////    }
////}




