using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQ.PlaywrightAutomation
{
    public class Demo10OpenEMRTest
    {
        [Test]
        public async Task AddPatientTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false, Channel = "chrome" });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();

            //page.SetDefaultTimeout

            await page.GotoAsync("http://demo.openemr.io/b/openemr/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            /*1.	Navigate onto http://demo.openemr.io/b/openemr/
                2.	Update username as admin
                3.	Update password as pass
                4.	Select language as English (Indian)
                5.	Click on the login button
                6.	Click on Patient --> Click New Search
                7.	Add the first name as john123
            */
            
            await page.Locator("xpath=//input[@id='authUser']").FillAsync("admin");
            await page.Locator("css=#clearPass").FillAsync("pass");
            await page.Locator("xpath=//select[@name='languageChoice']").SelectOptionAsync(new SelectOptionValue() { Label = "English (Indian)" });

            await page.Locator("xpath=//button[@id='login-button']").ClickAsync();

            await page.Locator("xpath=//div[text()='Patient']").ClickAsync();
            await page.Locator("xpath=//div[text()='New/Search']").ClickAsync();

            var framePat= page.FrameLocator("xpath=//iframe[@name='pat']");

            await framePat.Locator("xpath=//input[@id='form_fname']").FillAsync("john");
            await framePat.Locator("xpath=//input[@id='form_lname']").FillAsync("wick");
            await framePat.Locator("xpath=//input[@id='form_DOB']").FillAsync("2025-10-14");
            //gender 


            var frameConfirm = page.FrameLocator("xpath=//iframe[@id='modalframe']");
            await frameConfirm.Locator("//button[@id='confirmCreate']").ClickAsync();

            
            await Task.Delay(5000);

        }
    }
}
