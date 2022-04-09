using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace CatchException.Blogging.MongoDB;

[ConnectionStringName(BloggingDbProperties.ConnectionStringName)]
public interface IBloggingMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
