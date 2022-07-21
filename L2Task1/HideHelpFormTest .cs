using Aquality.Selenium.Browsers;
using L2Task1.PageObject;
using NUnit.Framework;

namespace L2Task1
{
    public class HideHelpFormTests : BaseTests
    {
        [Test]
        public void HideHelpTest()
        {
            var mainPage = new MainPageObject();
            Assert.IsTrue(mainPage.State.IsDisplayed,"Main page isn't opened");
            mainPage.ClickLinkMainPage();
            var card1 = new Card1PageObject();
            card1.ClickSendHelpButton();
            Assert.IsTrue(card1.CheckHideHelpForm(), "Help form isn't hide");

        }
    }
}