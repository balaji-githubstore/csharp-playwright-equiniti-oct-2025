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
        public async Task HdfcLoginFrameTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            //click on Go

            await Task.Delay(5000);

        }
    }
}
