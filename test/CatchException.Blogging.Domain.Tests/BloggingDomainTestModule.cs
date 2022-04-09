using CatchException.Blogging.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CatchException.Blogging;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(BloggingEntityFrameworkCoreTestModule)
    )]
public class BloggingDomainTestModule : AbpModule
{

}
