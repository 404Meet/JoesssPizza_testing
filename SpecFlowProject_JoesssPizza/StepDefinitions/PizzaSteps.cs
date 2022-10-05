using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace SpecFlowProject_JoesssPizza.StepDefinitions
{
    [Binding]
    public sealed class PizzaSteps
    {
        private ChromeDriver chromeDriver;

        public PizzaSteps() => chromeDriver = new ChromeDriver("C:\\Users\\meet.popat\\Downloads\\chromedriver_win32");


        [When(@"I press the Login button")]
        public void WhenIPressLoginButton()
        {
            chromeDriver.Navigate().GoToUrl("https://joessspizza.azurewebsites.net");
            var searchButton = chromeDriver.FindElement(By.CssSelector("a#login"));
            searchButton.Click();
        }

        [Given(@"I have navigated to Joesss Pizza website")]
        public void GivenIHaveNavigatedToJoesssPizzaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joessspizza.azurewebsites.net/");
            Assert.IsTrue(chromeDriver.Title.Contains("Home Page"));
        }

        [Given(@"I pressed Login with login keyword")]
        public void GivenIPressedLoginWithLoginKeyword()
        {

            chromeDriver.Navigate().GoToUrl("https://joessspizza.azurewebsites.net/Pizza");
            IWebElement PizzaPageHeader = chromeDriver.FindElement(By.TagName("h4"));
            Assert.IsTrue(PizzaPageHeader.Text.Contains("Your Pizza page."));
        }

        [Then(@"I should be navigate to Pizza page")]
        public void ThenIShouldBeNavigateToPizzaPage()
        {

            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(chromeDriver.Url.Contains("Pizza"));
        }


        [When(@"I press the Register button")]
        public void WhenIPressRegisterButton()
        {
            chromeDriver.Navigate().GoToUrl("https://joessspizza.azurewebsites.net");
            var searchButton = chromeDriver.FindElement(By.CssSelector("a#register"));
            searchButton.Click();
        }


        [Given(@"I pressed Register with Register keyword")]
        public void GivenIPressedRegisterWithRegisterKeyword()
        {

            chromeDriver.Navigate().GoToUrl("https://joessspizza.azurewebsites.net/Pizza");
            IWebElement PizzaPageHeader = chromeDriver.FindElement(By.TagName("h4"));
            Assert.IsTrue(PizzaPageHeader.Text.Contains("Your Pizza page."));
        }

        [Given(@"Verify Menu Item Count")]
        public void verifyMenuItemcount()
        {
            chromeDriver.Navigate().GoToUrl("https://joessspizza.azurewebsites.net");
            ReadOnlyCollection<IWebElement> menuItem = chromeDriver.FindElements(By.XPath("//ul[contains(@class,'navbar-nav me-auto')]/li"));
            Assert.AreEqual(menuItem.Count, 6);

        }

        [Given(@"I have navigated to Pizza Page")]
        public void GivenIHaveNavigatedToPizzaPage()
        {
            chromeDriver.Navigate().GoToUrl("https://joessspizza.azurewebsites.net/Pizza");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [When(@"I press add to cart")]
        public void WhenIPressAddToCart()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var searchButton = chromeDriver.FindElement(By.CssSelector("a#add-to-cart"));
            searchButton.Click();
            _ = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            chromeDriver.Navigate().GoToUrl("https://joessspizza.azurewebsites.net/Cart");
            _ = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [Then(@"Cart Page Opens")]
        public void ThenCartPageOpens()
        {
            chromeDriver.Navigate().GoToUrl("https://joessspizza.azurewebsites.net/Cart");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }


        [When(@"I click Continue Shopping")]
        public void ThenIClickContinueShopping()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var Conitinue_Shopping = chromeDriver.FindElement(By.XPath("/html/body/div/main/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Conitinue_Shopping);
        }

        [Then(@"I add another pizza to cart")]
        public void ThenIAddAnotherPizzaToCart()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var searchButton = chromeDriver.FindElement(By.CssSelector("a#add-to-cart"));
            searchButton.Click();

        }

        [When(@"Cart page comes up click on Checkout")]
        public void WhenCartPageComesUpClickOnCheckout()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var searchButton = chromeDriver.FindElement(By.CssSelector("a#total"));
            searchButton.Click();
        }

        [Then(@"Order is confirmed")]
        public void ThenOrderIsConfirmed()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [When(@"I click on delete")]
        public void WhenIClickOnDelete()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
            var Remove_from_cart = chromeDriver.FindElement(By.XPath("/html/body/div/form/table/tbody/tr/td/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Remove_from_cart);
        }

        [Then(@"Pizza should be removed from cart")]
        public void ThenPizzaShouldBeRemovedFromCart()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }


        public void Dispose()
        {
            if (chromeDriver != null)
            {
                chromeDriver.Dispose();
                chromeDriver = null;
            }
        }
    }
}