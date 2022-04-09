using CatchException.Blogging.Localization;
using Volo.Abp.Application.Services;

namespace CatchException.Blogging;

public abstract class BloggingAppService : ApplicationService
{
    protected BloggingAppService()
    {
        LocalizationResource = typeof(BloggingResource);
        ObjectMapperContext = typeof(BloggingApplicationModule);
    }
}
