using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace L2Task1.PageObject
{
    
    public class Card3PageObject : Form
    {
        private readonly static string personalForm = "//div[@class='personal-details']";
        public Card3PageObject() : base(By.XPath(personalForm), "Personal info form")
        {
        }
    }
}
