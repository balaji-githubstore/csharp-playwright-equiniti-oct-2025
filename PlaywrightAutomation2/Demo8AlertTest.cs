using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightAutomation
{
    public class Demo8AlertTest
    {
        [Test]
        public async Task HdfcLoginAlertTestAsync()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            string actualAlertMessage = null;
            //register the event handler to work on alert box
            page.Dialog += async (_, dialog) =>
            {
                actualAlertMessage = dialog.Message;
                await dialog.AcceptAsync();
            };

            //click on Go
            //auto handles the alert - use dialog event handler to get alert text
            await page.Locator("//img[@alt='Go']").ClickAsync();
           
            Console.WriteLine(actualAlertMessage);
            await Task.Delay(5000);
        }

        [Test]
        public async Task NasscomAlertTestAsync()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.nasscom.in/nasscom-membership", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            string actualAlertMessage = null;

            page.Dialog += async (_, dialog) =>
            {
                actualAlertMessage = dialog.Message;
                await dialog.AcceptAsync();
            };

            await page.Locator("xpath=//a[text()='Calculate Fee']").ClickAsync();

            Console.WriteLine(actualAlertMessage);
            await Task.Delay(5000);
        }
    }
}

