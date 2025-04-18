using AventStack.ExtentReports;
using NunitAppiumProj.Core;
using NunitAppiumProj.Pages;

namespace NunitAppiumProj.TestClass
{
    /* Oops: pillars 
     * Abstraction   : AppiumDriver Interface, 
     * Inheritance   : from Base class getting the driver instance
     * Encpsulation  : Making the members private/ Protected 
     * Polymorphism  : Implicit wait, time in minutes, seconds, Hours, action class, assert class
     *
      */
    [TestFixture]
    public class TestClass : Base
    {
        private Page1? P1;

        [Test, Order(1)]
        public void TestCase1()
        {
            test = Extent.CreateTest("TC01_AICHatBot Report");

            try
            {
                test.Log(Status.Info, "Starting AIChat Test Case");

                P1 = new Page1(driver, test);  // Initialize P1 AFTER test is created
                P1.AIChat();
            }
            catch (Exception e)
            {
                HandleException1(e, "Error in AiChatBot");
            }
        }

    }

}