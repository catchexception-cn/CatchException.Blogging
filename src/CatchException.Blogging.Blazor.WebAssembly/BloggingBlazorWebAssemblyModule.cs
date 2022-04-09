using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace CatchException.Blogging.Blazor.WebAssembly;

[DependsOn(
    typeof(BloggingBlazorModule),
    typeof(BloggingHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class BloggingBlazorWebAssemblyModule : AbpModule
{

}
