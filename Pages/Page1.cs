using NunitAppiumProj.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace NunitAppiumProj.Pages
{
    public class Page1 : Base
    {
        //  public AppiumDriver<AndroidElement> Driver { get; }

        public Page1(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver), "Driver cannot be null"); // Ensure driver is not null

        }

        //Method to perform action on Surah 1 using Locators
        public void Surah1()
        {
            ClickAndNavigateBack(AlFatiha, "AlFatiha");
        }

        //Method to perform action on Surah 1 using Locators
        public void Surah2M()
        {
            ClickAndNavigateBack(Surah2, "Surah 2");

        }

        private void ClickAndNavigateBack(IWebElement? element, string elementName)
        {
            try
            {
                element?.Click();
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
        IWebElement? AlFatiha => Driver?.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Al-Fatiha\"]");
        IWebElement? Surah2 => Driver?.FindElementByXPath("//adroid.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Aal-E-Imran\"]");

    }
}
