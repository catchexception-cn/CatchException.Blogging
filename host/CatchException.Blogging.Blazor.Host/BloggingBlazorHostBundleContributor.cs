using Volo.Abp.Bundling;

namespace CatchException.Blogging.Blazor.Host;

public class BloggingBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
