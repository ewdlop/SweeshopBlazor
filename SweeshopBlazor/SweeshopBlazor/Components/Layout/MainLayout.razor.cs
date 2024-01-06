
namespace SweeshopBlazor.Components.Layout;

public partial class MainLayout
{
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
        {
            await MasonryInterop.Init();
        }
        await base.OnAfterRenderAsync(firstRender);
    }
}