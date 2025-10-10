using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EQ.PlaywrightAutomation
{
    public class Demo6Frame
    {
        /// <summary>
        /// Switch to frame using xpath or css 
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task HdfcLoginFrameTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://netbanking.hdfcbank.com/netbanking/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            //switch to frame using xpath or css 
            var frame = page.FrameLocator("xpath=//frame[@name='login_page']");

            await frame.Locator("xpath=//input[@name='fldLoginUserId']").FillAsync("john123");
            await frame.Locator("xpath=//a[text()='CONTINUE']").ClickAsync();


            await Task.Delay(5000);

        }

        /// <summary>
        /// Switch to frame using name
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task HdfcLoginFrame2Test()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://netbanking.hdfcbank.com/netbanking/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            //switch to frame using name
            var frame = page.Frame("login_page");

            await frame.Locator("xpath=//input[@name='fldLoginUserId']").FillAsync("john123");
            await frame.Locator("xpath=//a[text()='CONTINUE']").ClickAsync();


            await Task.Delay(5000);

        }

        /// <summary>
        /// Switch to frame using url
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task HdfcLoginFrame3Test()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://netbanking.hdfcbank.com/netbanking/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            //switch to frame using url
            //var frame = page.FrameByUrl("https://netbanking.hdfcbank.com/netbanking/RSNBLogin.html?v=22");

            //var frame = page.FrameByUrl(new Regex(".*RSNBLogin.*"));

            //Func<String,bool> --> argument is string and return type is bool
            var frame = page.FrameByUrl(x => x.Contains("RSNBLogin"));

            //string url = "https://netbanking.hdfcbank.com/netbanking/RSNBLogin.html?v=22";

            //Console.WriteLine(url.Length);
            //if(url.Contains("RSNB"))
            //{

            //}

            await frame.Locator("xpath=//input[@name='fldLoginUserId']").FillAsync("john123");
            await frame.Locator("xpath=//a[text()='CONTINUE']").ClickAsync();


            await Task.Delay(5000);

        }

    }
}
