using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.WebDriver.Basics.Lection.DriverConfiguration;

namespace Selenium.WebDriver.Basics.Lection.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void Test3()
    {
        IWebDriver webDriver = new WebDriverFactory().GetDriver();
        webDriver.Navigate().GoToUrl("https://jqueryui.com/dialog/#modal-form");
        webDriver.Quit();
    }
    
    [Test]
    public void Test2()
    {
        IWebDriver webDriver = new ChromeDriver();
        webDriver.Navigate().GoToUrl("https://jqueryui.com/dialog/#modal-form");
        webDriver.Quit();
        var title = webDriver.Title;
        Console.WriteLine(title);
    }

    [Test]
    public void Test1()
    {
        IWebDriver webDriver = new ChromeDriver();
        var frameElement = webDriver.FindElement(By.CssSelector(".demo-frame"));
        // frameElement.Displayed;
        webDriver.SwitchTo().Frame(frameElement);
    }

    private bool IsUserDisplayed(string name, string email, string password)
    {
        IWebDriver webDriver = new ChromeDriver();
        var locator = $"";

        // bool isDisplayed;
        
        // try
        // {
        //     webDriver.FindElement(By.XPath(locator));
        //     isDisplayed = true;
        // }
        // catch (NoSuchElementException)
        // {
        //     isDisplayed = false;
        // }
        
        //elements
        var elements = webDriver.FindElements(By.XPath(locator))
            .Where(element => element.Displayed);
        return elements.Count() != 0;

        // return isDisplayed;
    }
}