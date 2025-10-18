using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQ.PlaywrightAutomation
{
    public class Demo2LaunchBrowser
    {
        [Test]
        public async Task Demo1LaunchBrowser()
        {
            var playwright = await Playwright.CreateAsync();

            var browser = await playwright.Chromium.LaunchAsync(new() { Headless=false ,Channel="chrome"});
           //var browser1 = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "msedge" });

            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.nasscom.in/nasscom-membership");

            //var contextEdge=await browser1.NewContextAsync();
            //var pageEdge=await contextEdge.NewPageAsync();

            //await pageEdge.GotoAsync("https://www.google.com");

           // await page.GotoAsync("", new PageGotoOptions() { Timeout = 0, WaitUntil = WaitUntilState.Load });
            var actualTitle = await page.TitleAsync();
            Console.WriteLine(actualTitle);


            //Console.WriteLine(await pageEdge.TitleAsync());

            var allLinkText= await page.Locator("xpath=//a").AllInnerTextsAsync();

            foreach (string linkText in allLinkText)
            {
                Console.WriteLine(linkText);
            }


            var allLocator = await page.Locator("xpath=//a").AllAsync();

            await allLocator[0].ClickAsync();

            await Task.Delay(3000);

        }


       


    }
}
