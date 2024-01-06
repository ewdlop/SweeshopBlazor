namespace SweetshopBlazor.Shared.interfaces;

public interface IClipboardService
{
    Task CopyToClipboard(string text);
}