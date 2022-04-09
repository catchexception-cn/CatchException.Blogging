using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CatchException.Blogging.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class BloggingBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Blogging";
}
