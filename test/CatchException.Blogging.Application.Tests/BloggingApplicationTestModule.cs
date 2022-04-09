using Volo.Abp.Modularity;

namespace CatchException.Blogging;

[DependsOn(
    typeof(BloggingApplicationModule),
    typeof(BloggingDomainTestModule)
    )]
public class BloggingApplicationTestModule : AbpModule
{

}
