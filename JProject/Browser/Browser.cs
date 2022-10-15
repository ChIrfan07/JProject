using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectJdot
{

    public class browser

    {
        public static IWebDriver driver;

        public static IWebDriver SeleniumInit(string browser)
        {


            if (browser == "Chrome")
            {
                ChromeOptions options = new ChromeOptions();

                options.AddArguments("start-maximized");


                // options.AddArguments("headless");


                //  options.AddArguments("incognito");

                //  options.AddArguments("disable-extensions");

                options.AddArguments("disable-popup-blocking");


                return driver = new ChromeDriver(options);


            }
            else if (browser == "Firefox")
            {
                return driver = new FirefoxDriver();
            }
            else if (browser == "Edge")

            {

                return driver = new EdgeDriver();
            }
            return driver;


        }

        public static void Closedriver()

        {

            driver.Close();

        }




        public void Write(By by, string value)
        {

            driver.FindElement(by).SendKeys(value);

        }

        public void Click(By by)
        {

            driver.FindElement(by).Click();

        }

        public void Clear(By by)
        {

            driver.FindElement(by).Clear();

        }

        public static void OpenUrl(string url)
        {

            driver.Url = url;

        }

        public void SwitchFramedefault()
        {
            driver.SwitchTo().DefaultContent();
        }

        public void SwitchFrame()
        {
           IWebElement iframe = driver.FindElement(By.Id("webpush-onsite"));
            driver.SwitchTo().Frame(iframe);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("deny")).Click();
            
            // driver.SwitchTo().Frame(driver.FindElement(by));
        }

       


        public void hover(By by)
    {
        Actions action = new Actions(driver);
        action.MoveToElement(driver.FindElement(by)).Perform();
    }

    public void scroll(By by)
    {

        var element = driver.FindElement(by);
        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
    }

        public static void scrollwindow()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500);");
        }

        public void drop(By by, string value)
    {
        SelectElement dropDown = new SelectElement(driver.FindElement(by));
        dropDown.SelectByText(value);
    }

   

        public static void ImplicitWait(int value)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(value);
        }
        public IWebElement ExplicitWait(By by, int value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(value));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
     

        public static void PlaybackWait(int miliSeconds)

        {

            Thread.Sleep(miliSeconds);

        }

    }
}


    




























        //public IWebElement WaitforElement(By by, int timeToReadyElement = 0)

        //{

        //    IWebElement element = null;

        //    try

        //    {

        //        if (timeToReadyElement != 0 && timeToReadyElement.ToString() != null)

        //        {

        //            PlaybackWait(timeToReadyElement * 1000);

        //        }

        //        element = driver.FindElement(by);

        //    }

        //    catch

        //    {

        //        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

        //        wait.Until(driver => IsPageReady(driver) == true && IsElementVisible(by) == true && IsClickable(by) == true);
        //        element = driver.FindElement(by);
        //    }
        //    return element;
        //}


