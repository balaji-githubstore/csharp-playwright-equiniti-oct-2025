using Microsoft.Playwright;

namespace EQ.PlaywrightAutomation
{
    public class Demo3NasscomForm
    {
        [Test]
        public async Task NascomMembershipTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.nasscom.in/nasscom-membership", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });


            //work only on dropdown with select tag
            await page.Locator("xpath=//select[@id='edit-field-company-type']").SelectOptionAsync(new SelectOptionValue() { Label = "Indian" });


            await page.Locator("xpath=//input[@placeholder='Company Name in India*']").FillAsync("Equniti");

            //enter address as Chennai
            await page.Locator("xpath=//textarea[@placeholder='Address*']").FillAsync("Chennai");

            await page.Locator("xpath=//label[contains(normalize-space(),'Engagement with Peers and Leaders')]").ClickAsync();

            //check - code of conduct checkbox under term & condition 
            await page.Locator("xpath=//label[@for='edit-field-mem-code-of-conduct-0']").ClickAsync();

            await Task.Delay(3000);

        }

        [Test]
        public async Task FBLoginTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.facebook.com/", new() { WaitUntil = WaitUntilState.Load, Timeout = 0 });

            await page.Locator("css=#email").FillAsync("Equniti");
            await page.Locator("css=#pass").FillAsync("Equniti");

            await page.Locator("css=button[name='login']").ClickAsync();

            await Task.Delay(3000);
        }
        
    }
}