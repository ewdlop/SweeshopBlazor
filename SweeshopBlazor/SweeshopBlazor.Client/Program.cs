using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using SweeshopBlazor.Client.Services;
using SweetshopBlazor.Shared.interfaces;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();
builder.Services.AddScoped<IClipboardService, ClipboardService>();
builder.Services.AddSingleton<IShoppingCartService, ShoppingCartService>();
await builder.Build().RunAsync();
