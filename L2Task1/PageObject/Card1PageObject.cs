using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using L2Task1.Elements;
using L2Task1.TestSettings;
using L2Task1.Utils;
using OpenQA.Selenium;


namespace L2Task1.PageObject
{
    internal class Card1PageObject : Form
    {
        private readonly static string passwordField = "//input[contains(@placeholder, 'Password')]";
        private readonly static string registrationForm = "//div[@class = 'login-form']";
        private readonly static string emailField = "//input[contains(@placeholder, 'email')]";
        private readonly static string domainField = "//input[contains(@placeholder, 'Domain')]";
        private readonly static string checkBoxTerms = "//span[contains(@class, 'checkbox')]";
        private readonly static string listOfDomains = "//div[@class = 'dropdown__list-item']";
        private readonly static string wrappedListOfDomains = "//div[@class = 'dropdown__field']";
        private readonly static string nextButton = "//a[@class ='button--secondary']";
        private readonly static string divhelpFormHidden = "//div[contains(@class, 'hidden')]";
        private readonly static string sendHelpFormButton = "//span[contains (@class, 'highlight')]";
        private readonly static string divCookies = "//div[@class ='cookies']";
        private readonly static string acceptCookiesButton = "//button[contains(@class,'button--transparent')]";
        private readonly static string timerDiv = "//div[contains (@class, 'timer')]";


        public Card1PageObject() : base(By.XPath(registrationForm), "Registration form")
        {
        }
        public void InputData() 
        { 
            var password = ElementFactory.GetTextBox(By.XPath(passwordField), "Password field");
            password.ClearAndType(Util.GenerateRandomPassword(
                Provider.InitializeTestData().CapitalLetter,
                Provider.InitializeTestData().Numeral,
                Provider.InitializeTestData().GeneralLetter,
                Provider.InitializeTestData().CyrillicLetter,
                Provider.InitializeTestData().NumberLetters));
            var mail = ElementFactory.GetTextBox(By.XPath(emailField), "Email field");
            mail.ClearAndType(Util.GenerateRandomEmail(
                Provider.InitializeTestData().NumberLetters,
                Provider.InitializeTestData().GeneralLetter));
            var domain = ElementFactory.GetTextBox(By.XPath(domainField), "Domain field");
            domain.ClearAndType(Util.GenerateRandomString(Provider.InitializeTestData().NumberLetters));
        }
        public void ClickWrappedList() 
        { 
            ElementFactory.GetComboBox(By.XPath(wrappedListOfDomains), "WrappedBox of Domain").Click();
          
        }
        public void CheckRandomDataFromList()
        {
            ElementFactory.FindElements<IButton>(By.XPath(listOfDomains), "List of Domains").Random().Click();
        }    
        public void CheckCheckBox() 
        { 
          ElementFactory.GetCheckBox(By.XPath(checkBoxTerms), "Registration checkBox").Check();
        }
        public void ClickNextButton() 
        { 
            ElementFactory.GetButton(By.XPath(nextButton), "Next button").ClickAndWait();
        }
        public void ClickSendHelpButton() 
        {
            ElementFactory.GetButton(By.XPath(sendHelpFormButton), "Send help button").Click();
        }
        public bool CheckHideHelpForm()
        {
            return ElementFactory.Get<Div>(By.XPath(divhelpFormHidden), "Help form div").State.IsExist;
        }
        
        public void ClickAcceptCookies() 
        {
            var alertAcceptButton = ElementFactory.GetButton(By.XPath(acceptCookiesButton), "Accept cookies button");
            ConditionalWait.WaitForTrue(() => alertAcceptButton.State.IsExist);
            alertAcceptButton.Click();
        }
        public bool CheckHideCookies() 
        {
            return ElementFactory.Get<Div>(By.XPath(divCookies), "Cookies div").State.IsDisplayed;
        }
        public string GetTimerInfo() 
        {
            return ElementFactory.Get<Div>(By.XPath(timerDiv), "Cookies div").Text;
        }
    }
}
 