using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Soenneker.Blazor.Masonry.Registrars;
using SweeshopBlazor.Client.Services;
using SweetshopBlazor.Shared.interfaces;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSingleton<IClipboardService, ClipboardService>();
builder.Services.AddMudServices();
builder.Services.AddMasonry();

await builder.Build().RunAsync();
