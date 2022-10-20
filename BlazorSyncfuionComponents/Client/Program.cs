using BlazorSyncfuionComponents.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzQzNjU4QDMyMzAyZTMzMmUzMEpxb2RQZDV1NG5CSlhyRnpWRUxlSFVUL1Vya1BlUjV0MGZ0R3ppeStQZ3M9");
builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();
