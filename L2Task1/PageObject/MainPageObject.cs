using Aquality.Selenium.Elements;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;


namespace L2Task1.PageObject
{
    internal class MainPageObject : Form
    {
        private static readonly string mainPageButton ="//button[@class ='start__button']";
        private static readonly string linkOnMainPage ="//a[@class ='start__link']";
        
        public MainPageObject() : base(By.XPath(mainPageButton), "Button on main Page")
        {
          
        }
        public void ClickLinkMainPage() 
        {
          ElementFactory.GetLink(By.XPath(linkOnMainPage), "MainPage link").Click();
        }
       
    }
}
