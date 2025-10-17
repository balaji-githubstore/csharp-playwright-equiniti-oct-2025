using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQ.PlaywrightAutomation
{
    public class Demo5MultipleTabs
    {
        [Test]
        public async Task DBFreeLoginTabsTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            //new() { Geolocation = new() { Latitude = 51.5f, Longitude = 0.12f ,Accuracy=0} }
            var context = await browser.NewContextAsync();

            //page --> points to tab 1
            var page = await context.NewPageAsync();


            //PageGotoOptions p = new PageGotoOptions();
            //p.Timeout = 0;
            //p.WaitUntil = WaitUntilState.Load;

            await page.GotoAsync("https://www.db4free.net/", new PageGotoOptions() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            //start tracking for any new tab/window opens or not
            var newTab = page.WaitForPopupAsync();

            //opens a new tab
            await page.Locator("xpath=//b[contains(normalize-space(),'phpMyAdmin')]").ClickAsync();


            //pageSecondTab --> points to tab 2
            //this will capture the new tab (page) opened by the previous click
            var pageSecondTab = await newTab;

            await pageSecondTab.Locator("xpath=//input[@id='input_username']").FillAsync("admin");
            //enter password as admin123
            await pageSecondTab.Locator("xpath=//input[@id='input_password']").FillAsync("admin123");
            //click on login 
            await pageSecondTab.Locator("xpath=//input[@id='input_go']").ClickAsync();


            //get the compelete error message - Access denied for user
            //div[contains(text(),'denied')]
            string actualError = await pageSecondTab.Locator("xpath=//div[@id='pma_errors']").InnerTextAsync();
            Console.WriteLine(actualError);


            //get the title from tab2 and print it
            string actualTitleForTab2 = await pageSecondTab.TitleAsync();
            Console.WriteLine(actualTitleForTab2);

            ////get the title from tab 1 and print it 
            Console.WriteLine(await page.TitleAsync());


            // Assert.That(actualError, Is.EqualTo("Error 1045: Access denied for user. Additional error information may be available, but is being hidden by the $cfg['Servers'][$i]['hide_connection_errors'] configuration directive."));

            Assert.That(actualError, Does.Contain("Access denied for current user"));

            //Assert.Equals("", "");
            //await Task.Delay(5000);
        }

        [Test]
        public async Task ShareowneronlineTabTest()
        {
            //https://eq-sol-ops-us-fd-main.azurefd.net/informational/contact-us/
            //click on Privacy Policy
            //click on login
            //enter username as jack 
            //click on submit 
            //get the error and print it - Please enter your password

            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();

            await page.GotoAsync("https://eq-sol-ops-us-fd-main.azurefd.net/informational/contact-us/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            var newTab = page.WaitForPopupAsync();

            await page.Locator("xpath=//a[text()='Privacy Policy']").ClickAsync();

            var page2 = await newTab;

            await page2.Locator("xpath=//a[@id='loginButton']").ClickAsync();

            await Task.Delay(5000);

        }



        [Test]
        public async Task ShareowneronlineRunWithTabTest()
        {

            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();

            await page.GotoAsync("https://eq-sol-ops-us-fd-main.azurefd.net/informational/contact-us/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            //var newTab = page.WaitForPopupAsync();

            //await page.Locator("xpath=//a[text()='Privacy Policy']").ClickAsync();

            //var page2 = await newTab;

            //await page2.Locator("xpath=//a[@id='loginButton']").ClickAsync();

            var page2=await page.RunAndWaitForPopupAsync(async () =>
            {
                await page.Locator("xpath=//a[text()='Privacy Policy']").ClickAsync();
            });


            await page2.Locator("xpath=//a[@id='loginButton']").ClickAsync();

            await Task.Delay(5000);

        }
    }
}

