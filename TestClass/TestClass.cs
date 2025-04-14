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

        [SetUp]
        public void Initialize()
        {
            try
            {
                if (driver != null)
                    P1 = new Page1(driver);
            }
            catch (Exception e)
            {
                HandleException1(e, "Failed to initialize Page1");
            }
        }

        //Test Method to Execute test using Locators for Surah 1 from Page Class
        [Test, Order(2)]
        public void TestCase1()
        {
            try
            {
                if (P1 != null)
                    P1?.Surah1();
            }
            catch (Exception e)
            {
                HandleException1(e, "Error in TestCase1");
            }
        }

        //Test Method to Execute test using Locators for Surah 1 from Page Class..This test case will be executed on priority bases

        [Test, Order(1)]
        public void TestCase2()
        {
            try
            {
                P1?.Surah2M();
            }
            catch (Exception e)
            {
                HandleException1(e, "Error in TestCase2");
            }
        }
    }

}