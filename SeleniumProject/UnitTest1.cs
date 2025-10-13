using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            IWebDriver driver = new EdgeDriver();

            ////network idle state
            driver.Url = "https://www.nasscom.in/nasscom-membership";


            //Console.WriteLine(driver.Title);

            //wait conditions 
            //click ---> presence, visible, clickable 

          //  SelectElement select = new SelectElement();

        }
    }
}