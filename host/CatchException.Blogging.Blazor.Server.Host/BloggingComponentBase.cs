using CatchException.Blogging.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CatchException.Blogging.Blazor.Server.Host;

public abstract class BloggingComponentBase : AbpComponentBase
{
    protected BloggingComponentBase()
    {
        LocalizationResource = typeof(BloggingResource);
    }
}
