using SweetShopBlazor.Shared;

namespace SweeshopBlazor.Components.Pages;

public partial class Home
{
    private List<Sweet> _sweets = new()
    {
        Sweet.GetRandomSweet(),
        Sweet.GetRandomSweet(),
        Sweet.GetRandomSweet(),
        Sweet.GetRandomSweet(),
        Sweet.GetRandomSweet()
    };

    protected override void OnAfterRender(bool firstRender)
    {
        if(firstRender)
        {
            //_sweets.Add(new Sweet());
            //_sweets.Add(new Sweet());
            //_sweets.Add(new Sweet());
            //_sweets.Add(new Sweet());
            //StateHasChanged();
        }
        base.OnAfterRender(firstRender);
    }
}

