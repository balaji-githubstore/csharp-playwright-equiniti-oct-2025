using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightAutomation
{
    public class Demo7Assignments
    {
        [Test]
        public async Task CitibankTestAsync()
        {

            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.citigroup.com/global/about-us/global-presence/india", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            await page.Locator("xpath=//div[text()='My Account']").HoverAsync();

            var newPopUp = page.WaitForPopupAsync();

            await page.Locator("xpath=//div[text()='Banking with Citi']").ClickAsync();

            //second tab IPage object is pointed by newTabPage
            var newTabPage= await newPopUp;

            await newTabPage.Locator("//input[@id='username']").FillAsync("test123");

            await Task.Delay(3000);
        }


        [Test]
        public async Task MeddiTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.medibuddy.in/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            if (await page.Locator("xpath=//a[text()='Login']").IsVisibleAsync())
            {
                await page.Locator("xpath=//a[text()='Login']").ClickAsync();
            }
            else
            {
                Console.WriteLine("Login button is not present");
            }

            await page.Locator("xpath=//div[text()='I have a Corporate Account']").ClickAsync();
            await page.Locator("xpath=//a[text()='Learn More']").ClickAsync();
            await page.Locator("xpath=//a[text()='skip']").ClickAsync();

            await page.Locator("xpath=//a[contains(text(),'Login using Username & Password')]").ClickAsync();

            await page.Locator("xpath=//input[@id='username']").FillAsync("john");
            await page.Locator("xpath=//button[(text()='Proceed')]").ClickAsync();

            await page.Locator("xpath=//input[@id='password']").FillAsync("john123");
            await page.Locator("xpath=//img[@alt='hide-password']").ClickAsync();

            await page.Locator("xpath=//button[text()='Sign In']").ClickAsync();
            //await Task.Delay(1000);

            //  var pwdwrong = page.Locator("xpath=//div[@ng-if='isPasswordWrong']").WaitForAsync().IsCompletedSuccessfully;
            //  if (pwdwrong.Status == TaskStatus.RanToCompletion)

            ////  var bol_PwdWrong = await page.Locator("xpath=//div[@ng-if='isPasswordWrong']").IsVisibleAsync();
            //if (await page.Locator("xpath=//div[contains(text(),'connect your corporate account')]").IsVisibleAsync())
            ////if(bol_PwdWrong.Equals(true)) 
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Error Message is not present");
            //}
            //string errorMessage = await page.Locator("xpath=//div[contains(text(),'connect your corporate account')]").InnerTextAsync();
            //Console.WriteLine("Error Message: " + errorMessage);

            if (await page.Locator("xpath=//div[contains(text(),'Sorry, We are not able to connect your corporate account')]").IsVisibleAsync())
            {
                string errorMessage = await page.Locator("xpath=//div[contains(text(),'Sorry, We are not able to connect your corporate account')]").InnerTextAsync();
                Console.WriteLine("Error Message: " + errorMessage);
            }
            else
            {
                Console.WriteLine("Error Message is not present");
            }

            await Task.Delay(3000);
        }
    }
    
}
