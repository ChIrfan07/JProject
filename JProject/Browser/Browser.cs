using AventStack.ExtentReports;
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


             //   options.AddArguments("headless");


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

        public static void Quitdriver()

        {

            driver.Quit();

        }




        //public void Write(By by, string value)
        //{

        //    driver.FindElement(by).SendKeys(value);

        //}

        //public void Click(By by)
        //{

        //    driver.FindElement(by).Click();

        //}

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
        public void Write(By by, string value)
        {
            try
            {
                driver.FindElement(by).SendKeys(value);
                TakeScreenshot(Status.Pass, "Enter Text");
            }
            catch (Exception ex)
            {

                TakeScreenshot(Status.Fail, "Enter Text: " + ex.ToString());
            }
        }

        public void Click(By by)
        {
            try
            {
                driver.FindElement(by).Click();
                TakeScreenshot("Click Element");
            }
            catch (Exception ex)
            {
                TakeScreenshot(Status.Fail, "Click Element: " + ex.ToString());
            }
        }
        public string GetElementText(By by)
        {
            string text;
            try
            {
                text = driver.FindElement(by).Text;
                Console.WriteLine(text);
            }
            catch
            {
                try
                {
                    text = driver.FindElement(by).GetAttribute("value");
                    Console.WriteLine(text);

                }
                catch
                {
                    text = driver.FindElement(by).GetAttribute("innerHTML");
                    Console.WriteLine(text);
                }
            }
            return text;
        }

        public string GetElementState(By by)
        {
            string elementState = driver.FindElement(by).GetAttribute("Disabled");

            if (elementState == null)
            {
                elementState = "enabled";
            }
            else if (elementState == "true")
            {
                elementState = "disabled";
            }
            return elementState;
        }
        public static void TakeScreenshot(string stepDetail)
        {
            string path = @"D:\JProject\JProject\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(Status.Pass, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }

        public static void TakeScreenshot(Status status, string stepDetail)
        {
            string path = @"D:\JProject\JProject\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder
                .CreateScreenCaptureFromPath(path + ".png").Build());
        }

        public void assertion()
        {
            string expectedd = "The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later.";

            string actualtextt = driver.FindElement(By.XPath("//div[@data-bind='html: $parent.prepareMessageForHtml(message.text)']")).Text;

            Assert.AreEqual(expectedd, actualtextt);

            Console.WriteLine("The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later." + expectedd);
        }

        public static void Assertion(string expect , By by)
        {
            string actualText = driver.FindElement(by).Text;
            Assert.AreEqual(expect, actualText);
            Console.WriteLine(expect, actualText);
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


