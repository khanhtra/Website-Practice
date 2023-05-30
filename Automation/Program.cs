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
    String URL = "https://www.youtube.com/";
    Assert.AreEqual(URL, driver.Url);
    Thread.Sleep(5000);
    IWebElement searchElement = driver.FindElement(By.CssSelector("input#search"));
    searchElement.SendKeys("Fly me to the moon");
    searchElement.SendKeys(Keys.Enter);
    Thread.Sleep(3000);
    driver.FindElement(By.LinkText("Fly Me to the Moon/Lucky (Sinatra/Jason Mraz & Colbie Caillat MASHUP) Rick Hale & Breea Guttery")).Click();
    String VideoURL = "https://www.youtube.com/watch?v=9Hf1t_BXGfk";
    Assert.AreEqual("https://www.youtube.com/watch?v=9Hf1t_BXGfk", driver.Url);

    
    }
}
}

