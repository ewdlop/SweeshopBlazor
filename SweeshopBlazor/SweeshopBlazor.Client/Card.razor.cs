using Microsoft.AspNetCore.Components;
using MudBlazor;
using SweetshopBlazor.Shared.interfaces;

namespace SweeshopBlazor.Client;

public partial class Card
{
    [Inject]
    public required IClipboardService ClipboardService { get; init; }
    [Inject]
    public required ISnackbar Snackbar { get; init; } 
    [Inject]
    public required NavigationManager NavigationManager { get; init; }
    [Parameter]
    public string ImageUrl { get; set; } = string.Empty;
    [Parameter]
    public string Header { get; set; } = string.Empty;
    [Parameter]
    public string Body { get; set; } = string.Empty;
    [Parameter]
    public string Href { get; set; } = string.Empty;
    [Parameter]
    public int Likes { get; set; }
    [Parameter]
    public int Height { get; set; } = 200;
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

    public void OnCopyToClipboard()
    {
        Snackbar.Add("Link Copied", Severity.Normal);
        ClipboardService.CopyToClipboard($"{NavigationManager.BaseUri}{Href}");
    }
}