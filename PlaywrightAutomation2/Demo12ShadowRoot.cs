using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightAutomation
{
    public class Demo12ShadowRoot
    {
        [Test]
        public async Task Demo1ShadowTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.salesforce.com/in/form/signup/sales-ee/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            await page.Locator("css=button[data-testid='minimize-button']").ClickAsync();

            await page.GetByTestId("minimize-button").ClickAsync();

            await Task.Delay(5000);
            //a[aria-label='Create an account']
        }

        [Test]
        public async Task Demo2ShadowTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.royalcaribbean.com/account/signin", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            //css
            await page.Locator("css=a[aria-label='Create an account']']").ClickAsync();

            //css - only work in playwright
            await page.Locator("text=Create an account").ClickAsync();


            await page.Locator("a:has-text('Create an account')").ClickAsync();


            await page.Locator("a", new PageLocatorOptions() { HasText = "Create an accoun" }).ClickAsync();



            await Task.Delay(5000);
            
        }
    }
}
