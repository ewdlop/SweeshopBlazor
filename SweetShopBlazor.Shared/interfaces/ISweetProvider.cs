using SweetShopBlazor.Shared;

namespace SweetshopBlazor.Shared.interfaces;

public interface ISweetProvider
{
    Sweet GetRandomSweet();
    Sweet GetSweetById(int id);
}
