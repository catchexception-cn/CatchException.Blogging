﻿using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace CatchException.Blogging;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(BloggingDomainSharedModule)
)]
public class BloggingDomainModule : AbpModule
{

}
