using Aquality.Selenium.Elements;
using OpenQA.Selenium;


namespace L2Task1.Elements
{
    public class Div : Element
    {
        public Div(By locator, string name, Aquality.Selenium.Core.Elements.ElementState state) : base(locator, name, state)
        {
        }

        protected override string ElementType => LocalizationManager.GetLocalizedMessage("loc.div");
    }
}
