using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class Page1 : Base
    {
        //  public AppiumDriver<AndroidElement> Driver { get; }

        public Page1(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            this.test = test ?? throw new ArgumentNullException(nameof(test));
        }


        //Method to perform action on Surah 1 using Locators
        public void AIChat()
        {
            AIChatbot(AIChatmenu, "AIChatBot", "What is SQA");
        }


        private void AIChatbot(IWebElement? element, string elementName , string searchcontent)
        {
            try
            {
                element?.Click();
                test?.Info("Clicked AIChat menu");
            }
            catch (Exception e)
            {
                HandleException1(e, elementName);
            }
            Thread.Sleep(3000);
            try
            {
                SearchText?.SendKeys(searchcontent);
                test?.Info("Entered search text");

            }
            catch (Exception e)
            {
                HandleException1(e, elementName);
            }
            try
            {
                Send.Click();
                test?.Info("Clicked send");

            }
            catch (Exception e)
            {
                HandleException1(e, elementName);
            }
            try
            {
                ErrorDialog.Click();
                test?.Info("Handled error dialog");
            }
            catch (Exception e)
            {
                HandleException1(e, elementName);
            }
            try
            {
                Driver?.Navigate().Back();
            }
            catch (Exception e)
            {
                HandleException1(e, "Upon Back Navigation");
            }
        }

        //Element Locator for Surah Location
        IWebElement? AIChatmenu => driver?.FindElementById("com.seaofgames.aichat.aiapps:id/clBasic");
        IWebElement? SearchText => driver?.FindElementById("com.seaofgames.aichat.aiapps:id/messageInput");
        IWebElement? Send => driver?.FindElementById("com.seaofgames.aichat.aiapps:id/sendButton");
        IWebElement? ErrorDialog => driver?.FindElementById("com.seaofgames.aichat.aiapps:id/tvContinueBtn");

    }
}
