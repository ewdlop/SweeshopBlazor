using MudBlazor.Services;
using Soenneker.Blazor.Masonry.Registrars;
using SweeshopBlazor.Client;
using SweeshopBlazor.Client.Services;
using SweeshopBlazor.Components;
using SweeshopBlazor.Services;
using SweetshopBlazor.Shared.interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddMudServices();
builder.Services.AddScoped<IClipboardService, ClipboardService>();
builder.Services.AddSingleton<ISweetProvider, SweetProvider>();
builder.Services.AddMasonry();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Card).Assembly);

app.Run();
