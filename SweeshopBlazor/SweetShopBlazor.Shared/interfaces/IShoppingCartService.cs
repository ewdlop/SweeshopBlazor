using SweetShopBlazor.Shared;

namespace SweetshopBlazor.Shared.interfaces;

public interface IShoppingCartService
{
    Task AddSweetToCart(Sweet sweet);
    Task RemoveSweetFromCart(Sweet sweet);
    Task<List<Sweet>> GetCart();
    Task ClearCart();
}