using Aquality.Selenium.Browsers;
using L2Task1.PageObject;
using NUnit.Framework;

namespace L2Task1
{
    public class AcceptCookiesTests : BaseTests
    {
        [Test]
        public void AcceptCookiesTest()
        {
            var mainPage = new MainPageObject();
            Assert.IsTrue(mainPage.State.IsDisplayed,"Main page isn't opened");
            mainPage.ClickLinkMainPage();
            var card1 = new Card1PageObject();
            card1.ClickAcceptCookies();
            Assert.IsFalse(card1.CheckHideCookies(), "Cookies isn't closed");

        }
    }
}