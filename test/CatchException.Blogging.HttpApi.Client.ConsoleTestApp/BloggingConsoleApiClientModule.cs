using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CatchException.Blogging;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BloggingHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class BloggingConsoleApiClientModule : AbpModule
{

}
