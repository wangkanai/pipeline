using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Wangkanai.Pipeline.Shared.Services;
using Wangkanai.Pipeline.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the Wangkanai.Pipeline.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
