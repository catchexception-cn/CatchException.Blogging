using CatchException.Blogging.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CatchException.Blogging.Pages;

public abstract class BloggingPageModel : AbpPageModel
{
    protected BloggingPageModel()
    {
        LocalizationResourceType = typeof(BloggingResource);
    }
}
