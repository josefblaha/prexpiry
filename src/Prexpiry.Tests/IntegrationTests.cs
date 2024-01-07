using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;

namespace Prexpiry.Tests;

public class IntegrationTests
{
    [Fact]
    public async Task Walking_skeleton_with_empty_table()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync();
        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://prexpiry-e2e.azurewebsites.net");
        
        await Expect(page.GetByRole(AriaRole.Heading, new PageGetByRoleOptions { Name = "Secrets" }))
            .ToBeVisibleAsync();

        await Expect(page.GetByRole(AriaRole.Table).Locator("tr")).ToHaveCountAsync(1);
    }
}