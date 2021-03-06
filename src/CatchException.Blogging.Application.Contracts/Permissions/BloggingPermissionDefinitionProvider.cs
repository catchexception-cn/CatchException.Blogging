using CatchException.Blogging.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CatchException.Blogging.Permissions;

public class BloggingPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BloggingPermissions.GroupName, L("Permission:Blogging"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BloggingResource>(name);
    }
}
