// See https://aka.ms/new-console-template for more information
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Automation
{
class Program
{
    public static IWebDriver driver;

    [Test]
    public static void Main(){
    driver = new ChromeDriver();
    driver.Navigate().GoToUrl("https://www.google.com");
    driver.Manage().Window.Maximize();
    IWebElement element = driver.FindElement(By.Id("APjFqb"));
    element.SendKeys("youtube");
    element.SendKeys(Keys.Enter);
    driver.FindElement(By.CssSelector(".DKV0Md")).Click();
    }
}
}

