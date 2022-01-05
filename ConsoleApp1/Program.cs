using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Random Randoms = new Random();
            //IWebDriver webDriver;
            //int Random_number = 
            string Text = "";
            IWebDriver driver = new ChromeDriver();
            //Console.WriteLine("Hello World!");
            try
            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driver.Navigate().GoToUrl("https://hk.finance.yahoo.com/quote/PINS/");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                var Name = driver.FindElement(By.XPath("//*[@id='quote-header-info']/div[2]/div[1]/div[1]/h1")).Text;
                Text = Text + Name + "\r\n\r\n";
                //driver.Navigate().
                var point = driver.FindElement(By.XPath("//*[@id='quote-summary']/div[1]")).Text;
                Text = Text + point + "\r\n\r\n";
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Randoms.Next(1, 10));
                var point2 = driver.FindElement(By.XPath("//*[@id='quote-summary']/div[2]")).Text;
                Text = Text + point2 + "\r\n\r\n";
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Randoms.Next(1, 10));
                Console.WriteLine(Text);
                Text = "";

                for (int i = 1; i < 10; i++)
                {
                    if (i != 2  && i != 7)
                    {
                        
                        var Txet = driver.FindElement(By.XPath("//*[@id='quoteNewsStream-0-Stream']/ul/li[" + i + "]/div/div/div[2]/p")).Text;
                        Text = Text + Txet + "\r\n\r\n";
                        //*[@id="quoteNewsStream-0-Stream"]/ul/li[15]/div/div/div[2]/p/text()
                    }
                }
                Console.WriteLine(Text);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            driver.Quit();
        }
        //async class Chorome() 
        //{
        //
        //}        
    }
}
