using L2Task1.PageObject;
using L2Task1.TestSettings;
using NUnit.Framework;

namespace L2Task1
{
    public class TimerTests : BaseTests
    {
        [Test]
        public void TimerTest()
        {
            var mainPage = new MainPageObject();
            Assert.IsTrue(mainPage.State.IsDisplayed,"Main page isn't opened");
            mainPage.ClickLinkMainPage();
            var card1 = new Card1PageObject();
            Assert.AreEqual(Provider.InitializeTestData().TimeOnTimer, card1.GetTimerInfo(), "Time on timer is different");
           
        }
    }
}