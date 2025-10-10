using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject
{
    public class Tests
    {

        //[Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();

            //network idle state
            driver.Url = "https://www.nasscom.in/nasscom-membership";


            Console.WriteLine(driver.Title);

            //wait conditions 
            //click ---> presence, visible, clickable 

        }
    }
}