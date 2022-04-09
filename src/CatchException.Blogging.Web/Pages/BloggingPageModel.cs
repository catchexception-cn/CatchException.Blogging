using CatchException.Blogging.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CatchException.Blogging.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BloggingPageModel : AbpPageModel
{
    protected BloggingPageModel()
    {
        LocalizationResourceType = typeof(BloggingResource);
        ObjectMapperContext = typeof(BloggingWebModule);
    }
}
