using Aquality.Selenium.Browsers;
using L2Task1.TestSettings;
using NUnit.Framework;

namespace L2Task1
{
    public class BaseTests
    {
       
        
        [SetUp]
        protected void SetUp()
        {
           
            AqualityServices.Browser.GoTo(Provider.InitializeTestData().Url);
            AqualityServices.Browser.Maximize();

        }

        [TearDown]
        protected void TearDown()
        {
            AqualityServices.Browser.Quit();
        }
    }
}

