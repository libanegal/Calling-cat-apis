using Calling_Cat_Apis;
using Microsoft.Extensions.DependencyInjection;


var services = new ServiceCollection();
services.AddScoped<ICatService, CatService>();
var serviceProvider = services.BuildServiceProvider();
var cats = serviceProvider.GetRequiredService<ICatService>();
await cats.GetCatServiceAsync();