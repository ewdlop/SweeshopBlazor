using Microsoft.AspNetCore.Components;
using SweetShopBlazor.Shared;

namespace SweeshopBlazor.Components.Pages
{
    public partial class BrowseSweet
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        public required ISweetProvider SweetService { get; set; }
        public Sweet Sweet { get; protected set; }
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                Sweet = SweetService.GetSweetById(Id);
            }
            base.OnAfterRender(firstRender);
        }
    }
}