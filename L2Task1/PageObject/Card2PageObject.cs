using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using L2Task1.Utils;
using OpenQA.Selenium;
using WindowsInput;


namespace L2Task1.PageObject
{
    internal class Card2PageObject : Form
    {
        private readonly static string interestsForm = "//div[@class = 'avatar-and-interests__form']";
        private readonly static string checkBoxes = "//label [@class='checkbox__label']";
        private readonly static string unselectAll = "//label[@for = 'interest_unselectall']";
        private readonly static string uploadLink = "//a[contains(@class, 'upload-button')]";
        private readonly static string nextButton = "//button[contains(text(),'Next')]";
        InputSimulator keyboard = new InputSimulator();


        public Card2PageObject() : base(By.XPath(interestsForm), "Interests form")
        {
        }
        public void CheckCheckBoxes()
        {   
            ElementFactory.GetCheckBox(By.XPath(unselectAll), "Unselect all checkbox").Check();
            var boxes = ElementFactory.FindElements<ICheckBox>(By.XPath(checkBoxes), "List of checkboxes");
            boxes.RemoveAt(20);
            boxes.RemoveAt(17);
            boxes.Random().Check();
            boxes.Random().Check();
            boxes.Random().Check();
        }
        public void UploadPhoto()
        {
            string pathToPicture = Directory.GetCurrentDirectory() + @"..\TestSettings\1.jpg";
            ElementFactory.GetLink(By.XPath(uploadLink), "Upload link").Click();
            Thread.Sleep(400);
            keyboard.Keyboard.TextEntry(pathToPicture);
            Thread.Sleep(400);
            keyboard.Keyboard.KeyDown(VirtualKeyCode.RETURN);
            Thread.Sleep(100);
        }
        public void ClickNextButton() 
        {
            ElementFactory.GetButton(By.XPath(nextButton), "Next button").WaitAndClick();
        }
    }
}
