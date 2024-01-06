using Microsoft.AspNetCore.Components;
using Soenneker.Blazor.Masonry;
using SweetshopBlazor.Shared.interfaces;
using SweetShopBlazor.Shared;

namespace SweeshopBlazor.Components.Pages;

public partial class Home
{
    [Inject]
    public required ISweetProvider SweetProvider { get; init; }
    private List<Sweet> Sweets { get; init; } = new();

    protected override void OnInitialized()
    {
        for (int i = 0; i < 10; i++)
        {
            Sweets.Add(SweetProvider.GetSweetById(i));
        }
    }
}

