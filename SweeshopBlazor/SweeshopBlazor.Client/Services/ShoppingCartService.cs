using SweetshopBlazor.Shared.interfaces;
using SweetShopBlazor.Shared;

namespace SweeshopBlazor.Client.Services;

public class ShoppingCartService : IShoppingCartService
{   
    private readonly List<Sweet> _cart = new(); 
    public Task AddSweetToCart(Sweet sweet)
    {
        _cart.Add(sweet);
        return Task.CompletedTask;
    }

    public Task ClearCart()
    {
        _cart.Clear();
        return Task.CompletedTask;
    }

    public Task<List<Sweet>> GetCart()
    {
        return Task.FromResult(_cart);
    }

    public Task RemoveSweetFromCart(Sweet sweet)
    {
        _cart.Remove(sweet);
        return Task.CompletedTask;
    }
}