using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject2
{
    public class Demo1Test
    {
        [Test]
        public void AddPatientTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://demo.openemr.io/b/openemr"; //wait for page load

            Console.WriteLine(driver.Title);

            //FindElement --> check for presence of element in 0.5s
            driver.FindElement(By.XPath("//input[@id='authUser']")).SendKeys("admin");
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys("pass");

            //dropdown with Select tag
            SelectElement selectLang = new SelectElement(driver.FindElement(By.XPath("//select[@name='languageChoice']")));
            selectLang.SelectByText("English (Indian)");


            driver.FindElement(By.XPath("//button[@id='login-button']")).Click();


            driver.FindElement(By.XPath("//button[text()='Ask again later']")).Click();

            //go with click
            driver.FindElement(By.XPath("//div[text()='Patient']")).Click();

            //Actions actions=new Actions(driver);
            //actions.MoveToElement(driver.FindElement(By.XPath("//div[text()='Patient']"))).Perform();

            driver.FindElement(By.XPath("//div[text()='New/Search']")).Click();


            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='pat']")));

            driver.FindElement(By.XPath("//input[@id='form_fname']")).SendKeys("john");
            driver.FindElement(By.XPath("//input[@id='form_lname']")).SendKeys("john");
            driver.FindElement(By.XPath("//input[@id='form_DOB']")).SendKeys("2025-10-17");

            SelectElement selectGender = new SelectElement(driver.FindElement(By.XPath("//select[@name='form_sex']")));
            selectGender.SelectByText("Female");

            driver.FindElement(By.XPath("//button[@name='create']")).Click();

            //switch to main html
            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='modalframe']")));

            driver.FindElement(By.XPath("//button[@id='confirmCreate']")).Click();

            //switch to main html
            driver.SwitchTo().DefaultContent();


            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(30);
            // wait.IgnoreExceptionTypes(typeof(NoAlertPresentException));
            wait.IgnoreExceptionTypes(typeof(Exception));
            // wait.PollingInterval = TimeSpan.FromSeconds(1);

            wait.Until(x => x.SwitchTo().Alert());

            string alertText = driver.SwitchTo().Alert().Text;
            Console.WriteLine(alertText);

            driver.SwitchTo().Alert().Accept();

            driver.FindElement(By.XPath("//div[@class='closeDlgIframe']")).Click();


            //iframe[@name='pat']
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='pat']")));

            string actualText = driver.FindElement(By.XPath("//span[contains(text(),'Medical Record')]")).Text;
            Console.WriteLine(actualText);

            Assert.That(actualText, Does.Contain("Medical Record"));
        }


        [Test]
        public void DBFreeTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/"; //wait for page load

            driver.FindElement(By.XPath("//b[contains(normalize-space(),'phpMyAdmin')]")).Click();

            //switch to 2nd tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.XPath("//input[@id='input_username']")).SendKeys("john");
            driver.FindElement(By.XPath("//input[@id='input_password']")).SendKeys("john");
        }
    }
}
