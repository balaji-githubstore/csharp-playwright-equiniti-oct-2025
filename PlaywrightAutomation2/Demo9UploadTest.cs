using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// Upload
namespace PlaywrightAutomation
{
    public class Demo9UploadTest
    {
        /// <summary>
        /// Upload using //input[@type='file']
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UploadOption1Test()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.ilovepdf.com/pdf_to_word", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            await page.Locator("xpath=//input[@type='file']").SetInputFilesAsync(@"D:\Balaji\Profile.pdf");

            await Task.Delay(5000);
        }

        /// <summary>
        /// Upload using RunWith methods in playwright 
        /// </summary>
        /// <returns></returns>

        [Test]
        public async Task UploadOption2Test()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.ilovepdf.com/pdf_to_word", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });


            var fileChooser = await page.RunAndWaitForFileChooserAsync(async () =>
            {
                await page.Locator("xpath=//span[text()='Select PDF file']").ClickAsync();
            });

            await fileChooser.SetFilesAsync(@"D:\Balaji\Profile.pdf");

            await Task.Delay(5000);
        }


        /// <summary>
        /// Upload using event handler - keep it as last option
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UploadOption3Test()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.ilovepdf.com/pdf_to_word", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            //keep event handler as last option
            //register before click on upload file
            page.FileChooser += async (_, fileChooser) =>
            {
                await fileChooser.SetFilesAsync(@"D:\Balaji\Profile.pdf");
            };

            //click on select pdf file button
            await page.Locator("xpath=//span[text()='Select PDF file']").ClickAsync();

            await Task.Delay(5000);
        }

    }
}
