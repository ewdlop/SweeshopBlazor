using Microsoft.AspNetCore.Components;
using SweetshopBlazor.Shared.interfaces;
using SweetShopBlazor.Shared;

namespace SweeshopBlazor.Components.Pages
{
    public partial class BrowseSweet
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        public required ISweetProvider SweetService { get; set; }
        public Sweet? Sweet { get; protected set; }
        protected override void OnInitialized()
        {
            Sweet = SweetService.GetSweetById(Id);
        }
    }
}