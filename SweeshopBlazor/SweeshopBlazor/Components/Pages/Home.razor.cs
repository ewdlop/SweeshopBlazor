using Microsoft.AspNetCore.Components;
using Soenneker.Blazor.Masonry;
using SweetShopBlazor.Shared;

namespace SweeshopBlazor.Components.Pages;

public partial class Home
{
    [Inject]
    public required ISweetProvider SweetProvider { get; set; }
    private List<Sweet> _sweets = new();

    protected override void OnInitialized()
    {
        for (int i = 0; i < 10; i++)
        {
            _sweets.Add(SweetProvider.GetSweetById(i));
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await MasonryInterop.Init(".mud-container");
    }
}

