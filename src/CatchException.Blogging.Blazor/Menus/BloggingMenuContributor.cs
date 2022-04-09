using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace CatchException.Blogging.Blazor.Menus;

public class BloggingMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(BloggingMenus.Prefix, displayName: "Blogging", "/Blogging", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
