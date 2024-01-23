using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedLib;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSingleton<QDataService>();

await builder.Build().RunAsync();