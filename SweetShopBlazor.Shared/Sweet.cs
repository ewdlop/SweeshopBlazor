namespace SweetShopBlazor.Shared;

public record Sweet(string Name, string Description, int Likes, int Id);

public interface ISweetProvider
{
    Sweet GetRandomSweet();
    Sweet GetSweetById(int id);
}