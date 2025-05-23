using Microsoft.AspNetCore.Identity;
using Wangkanai.Pipeline.Data;

namespace Wangkanai.Pipeline.Components.Account;

internal sealed class IdentityUserAccessor(UserManager<PipelineUser> userManager, IdentityRedirectManager redirectManager)
{
    public async Task<PipelineUser> GetRequiredUserAsync(HttpContext context)
    {
        var user = await userManager.GetUserAsync(context.User);

        if (user is null)
        {
            redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
        }

        return user;
    }
}
