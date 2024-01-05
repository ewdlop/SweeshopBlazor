using Microsoft.AspNetCore.Components;

namespace SweeetShopBlazor.UI
{
    public partial class Card
    {
        [Parameter]
        public string Header { get; set; }
        [Parameter]
        public int Likes { get; set; }
    }
}