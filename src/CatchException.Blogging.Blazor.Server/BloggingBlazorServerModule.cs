using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace CatchException.Blogging.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(BloggingBlazorModule)
    )]
public class BloggingBlazorServerModule : AbpModule
{

}
