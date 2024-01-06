using SweetshopBlazor.Shared.interfaces;
using SweetShopBlazor.Shared;

namespace SweeshopBlazor.Services;

public class SweetProvider : ISweetProvider
{
    private readonly List<Sweet> _sweets = new List<Sweet>();
    

    public SweetProvider()
    {
        for (int i = 0; i < 10; i++)
        {
            _sweets.Add(CreateSweetById(i));
        }
    }
    public static readonly string[] SweetNamesWithDescription = new string[]
    {
        "Chocolate - A sweet, usually brown, food made from cacao seeds, that is usually sold in a block, or a small sweet made from this",
        "Candy - A sweet food made from sugar or chocolate, or a piece of this",
        "Lollipop - A hard sweet on the end of a small stick",
        "Gum - A sweet that you chew but do not swallow",
        "Cookie - A small, flat, sweet food made from flour and sugar",
        "Cake - A sweet food made with a mixture of flour, eggs, fat, and sugar",
        "Ice Cream - A very cold, sweet food made from frozen milk or cream, sugar, and a flavour",
        "Cupcake - A small, round cake",
        "Brownie - A small, square piece of rich cake, usually made with chocolate",
        "Pie - A type of food made with meat, vegetables, or fruit covered in pastry and baked",
    };

    public Sweet GetRandomSweet()
    {
        Random randomLikes = new();
        Random randomSweet = new Random();
        int seed = randomSweet.Next(0, SweetNamesWithDescription.Length);
        string nameWithDescription = SweetNamesWithDescription[seed];
        string name = nameWithDescription.Split(" - ")[0].Trim();
        string description = nameWithDescription.Split(" - ")[1].Trim();
        return new Sweet(name, description, randomLikes.Next(0, 10), seed);
    }

    private static Sweet CreateSweetById(int id)
    {
        Random randomLikes = new();
        string nameWithDescription = SweetNamesWithDescription[id];
        string name = nameWithDescription.Split(" - ")[0].Trim();
        string description = nameWithDescription.Split(" - ")[1].Trim();
        return new Sweet(name, description, randomLikes.Next(0, 10), id);
    }

    public Sweet GetSweetById(int id)
    {
        return _sweets[id];
    }
}
