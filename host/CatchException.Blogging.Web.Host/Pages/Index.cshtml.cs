using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace CatchException.Blogging.Pages;

public class IndexModel : BloggingPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
