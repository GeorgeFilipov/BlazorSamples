using MentorMate.BlazorWebAssembly.App;
using MentorMate.Shared;
using MentorMate.Shared.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ChatState>();


builder.Services.AddHttpClient<DataService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7119/");
});

await builder.Build().RunAsync();
