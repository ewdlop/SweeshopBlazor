using Microsoft.AspNetCore.Components;

namespace SweeshopBlazor.Client;

public partial class Card
{
    [Parameter]
    public string ImageUrl { get; set; }
    [Parameter]
    public string Header { get; set; }
    [Parameter]
    public string Body { get; set; }
    [Parameter]
    public string Href { get; set; }
    [Parameter]
    public int Likes { get; set; }
    public bool Liked { get; protected set; }

    public void ToggleLikes(bool like)
    {
        if (like)
        {
            Likes++;
        }
        else
        {
            Likes--;
        }
    }

    public void ToggleLiked()
    {
        Liked = !Liked;
        ToggleLikes(Liked);
    }
}