using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightAutomation
{
    public class Demo11TableTest
    {
        [Test]
        public async Task Demo1WebTableTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();

            await page.GotoAsync("https://datatables.net/extensions/select/examples/checkbox/checkbox.html", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            string name1= await page.Locator("xpath=//table[@id='example']/tbody/tr[1]/td[2]").InnerTextAsync();
            Console.WriteLine(name1);
          
            await Task.Delay(5000);

        }

        [Test]
        public async Task Demo2WebTableTest()
        {

            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();

            await page.GotoAsync("https://datatables.net/extensions/select/examples/checkbox/checkbox.html", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

          

            for (int i=1;i<=10; i++)
            {
                string name1 = await page.Locator($"xpath=//table[@id='example']/tbody/tr[{i}]/td[2]").InnerTextAsync();
                Console.WriteLine(name1);

                if(name1.Equals("Brenden Wagner"))
                {
                    await page.Locator($"xpath=//table[@id='example']/tbody/tr[{i}]/td[1]").ClickAsync();
                    break;
                }
            }

            await Task.Delay(5000);
        }


        [Test]
        public async Task Demo3WebTableTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();

            await page.GotoAsync("https://datatables.net/extensions/select/examples/checkbox/checkbox.html", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            for(int p=1;p<=7;p++)
            {
                int rowCount = await page.Locator("xpath=//table[@id='example']/tbody/tr").CountAsync();

                for (int i = 1; i <= rowCount; i++)
                {
                    string name1 = await page.Locator($"xpath=//table[@id='example']/tbody/tr[{i}]/td[2]").InnerTextAsync();
                    Console.WriteLine(name1);
                }

                await page.Locator("css=button[data-dt-idx='next']").ClickAsync();

            }

            
            await Task.Delay(5000);

        }
    }
}
