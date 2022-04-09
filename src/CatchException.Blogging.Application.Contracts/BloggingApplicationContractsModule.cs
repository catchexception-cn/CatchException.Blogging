using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace CatchException.Blogging;

[DependsOn(
    typeof(BloggingDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class BloggingApplicationContractsModule : AbpModule
{

}
