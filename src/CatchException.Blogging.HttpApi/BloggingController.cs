using CatchException.Blogging.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CatchException.Blogging;

public abstract class BloggingController : AbpControllerBase
{
    protected BloggingController()
    {
        LocalizationResource = typeof(BloggingResource);
    }
}
