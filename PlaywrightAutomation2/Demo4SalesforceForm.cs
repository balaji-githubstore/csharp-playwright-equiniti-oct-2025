using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQ.PlaywrightAutomation
{
    public class Demo2Salesforce
    {
        [Test]
        public async Task SalesforceRegisterTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false,Channel="chrome" });
            //new() { Geolocation = new() { Latitude = 51.5f, Longitude = 0.12f ,Accuracy=0} }
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.salesforce.com/in/form/signup/sales-ee/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            await page.Locator("xpath=//input[@name='UserFirstName']").FillAsync("Equniti");
            await page.Locator("xpath=//input[@name='UserLastName']").FillAsync("Equniti");
            await page.Locator("xpath=//input[@name='UserTitle']").FillAsync("Equniti");
            await page.Locator("xpath=//span[text()='Next']").ClickAsync();

            //select - 21 - 200 employees
            await page.Locator("xpath=//select[@name='CompanyEmployees']").SelectOptionAsync(new SelectOptionValue() { Label = "21 - 200 employees" });

            await page.Locator("xpath=//input[@name='CompanyName']").FillAsync("Equniti");
            await page.Locator("xpath=//span[text()='Next']").ClickAsync();


            await page.Locator("xpath=//input[@name='UserEmail']").FillAsync("Equniti@gmail.com");

            await page.Locator("xpath=(//div[@class='checkbox-ui'])[2]").ClickAsync();

            // await page.Locator("xpath=//div[@class='checkbox-ui']").Nth(1).ClickAsync();

            //await page.Locator("xpath=//select[@name='CompanyEmployees']").SelectTextAsync(new LocatorSelectTextOptions() { })
            /*
             * Task 1(Important)
                1.	Navigate onto https://www.salesforce.com/in/form/signup/freetrial-sales/
                2.	Enter first name as “John”
                3.	Enter last name as “wick”
                4.	Enter work email as “john@gmail.com”
                5.	Select Job title as “IT Manager”
                6.	Select Employees as “21 - 200 employees”
                7.	Select country as “United Kingdom”
                8.	Do not fill the phone number
                9.	Click on check box 
                10.	Click on submit
                11.	Get the error message displayed “Enter a valid phone number”

             */

            await page.Locator("xpath=//input[@name='UserEmail']").PressAsync("JACK12");
            await page.Locator("xpath=//input[@name='UserEmail']").PressSequentiallyAsync("JACK12");

            await Task.Delay(3000);
        }

        [Test]
        public async Task Demo2EQShareTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            //new() { Geolocation = new() { Latitude = 51.5f, Longitude = 0.12f ,Accuracy=0} }
            var context = await browser.NewContextAsync();
            var page =  await context.NewPageAsync();

            await page.GotoAsync("https://eq-sol-ops-us-fd-main.azurefd.net/informational/contact-us/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            await page.Locator("xpath=//div[text()='Search or select company']").ClickAsync();
            await page.Locator("xpath=//div[normalize-space()='ROHDE TAX CLIENT 1']").ClickAsync();

            //await page.FrameByUrl("")

            var actualText= await page.Locator("xpath=//p[contains(text(),'two business days')]").InnerTextAsync();
            Console.WriteLine(actualText);

            Assert.That(actualText, Does.Contain("Please submit the following information"));
            await Task.Delay(3000);


        }
    }
}
