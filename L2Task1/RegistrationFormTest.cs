using Aquality.Selenium.Browsers;
using L2Task1.PageObject;
using NUnit.Framework;

namespace L2Task1
{
    public class RegitstrationFormTests : BaseTests
    {
        [Test]
        public void RegistrationTest()
        {
            var mainPage = new MainPageObject();
            Assert.IsTrue(mainPage.State.IsDisplayed,"Main page isn't opened");
            mainPage.ClickLinkMainPage();
            var card1 = new Card1PageObject();
            Assert.IsTrue(card1.State.IsDisplayed, "Card1 page isn't opened");
            card1.InputData();
            card1.ClickWrappedList();
            card1.CheckRandomDataFromList();
            card1.CheckCheckBox();
            card1.ClickNextButton();
            var card2 = new Card2PageObject();
            Assert.IsTrue(card2.State.IsDisplayed, "Card2 page isn't opened");
            card2.CheckCheckBoxes();
            card2.UploadPhoto();
            card2.ClickNextButton();
            var card3 = new Card3PageObject();
            Assert.IsTrue(card3.State.IsDisplayed, "Card3 page isn't opened");

            
        }
    }
}