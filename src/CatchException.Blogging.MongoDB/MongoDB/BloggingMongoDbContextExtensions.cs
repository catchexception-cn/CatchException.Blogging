using Volo.Abp;
using Volo.Abp.MongoDB;

namespace CatchException.Blogging.MongoDB;

public static class BloggingMongoDbContextExtensions
{
    public static void ConfigureBlogging(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
